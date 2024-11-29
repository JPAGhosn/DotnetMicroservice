import {inject, Injectable} from '@angular/core';
import {catchError, finalize, tap, throwError} from 'rxjs';
import {HttpErrorResponse} from '@angular/common/http';
import {getHttpErrorMessage} from '@shared/helpers/get-http-error-message';
import {AuthenticationForm} from '@authentication/pages/authentication/forms/authentication-form';
import {AuthenticationService} from '@authentication/pages';
import {RemoteService} from '@authentication/remotes';
import {CredentialsService} from '@shared/services/credentials.service';
import {Router} from '@angular/router';

@Injectable()
export class SignInService {
  form = inject(AuthenticationForm)
  authenticationService = inject(AuthenticationService)
  remote = inject(RemoteService)
  credentialsService = inject(CredentialsService)
  router = inject(Router)

  signIn() {
    const emailOrPhoneControl = this.form.formGroup.controls.emailOrPhone;
    const passwordControl = this.form.formGroup.controls.password;

    emailOrPhoneControl.markAsTouched();
    passwordControl.markAsTouched();

    if (emailOrPhoneControl.invalid || passwordControl.invalid) {
      return;
    }

    const emailOrPhone = emailOrPhoneControl.value!;
    const password = passwordControl.value!;

    this.authenticationService.loading.set(true)
    this.remote.signIn(emailOrPhone, password).pipe(
      tap(response => {
        this.authenticationService.errorMessage.set("")
        this.credentialsService.setCredentials(response);
        this.router.navigate(["/"]);
      }),
      catchError((err: HttpErrorResponse) => {
        if (err.status === 401) {
          this.authenticationService.errorMessage.set("Wrong email or password");
        } else {
          const errorMessage = getHttpErrorMessage(err);
          this.authenticationService.errorMessage.set(errorMessage)
        }
        return throwError(() => err);
      }),
      finalize(() => {
        this.authenticationService.loading.set(false);
      })
    ).subscribe();
  }
}
