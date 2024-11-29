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
export class SignUpService {
  form = inject(AuthenticationForm)
  authenticationService = inject(AuthenticationService)
  remote = inject(RemoteService)
  credentialsService = inject(CredentialsService)
  router = inject(Router)

  signUp() {
    const {firstName, lastName, emailOrPhone, password} = this.form.formGroup.controls;
    if (firstName.invalid || lastName.invalid || emailOrPhone.invalid || password.invalid) {
      return;
    }

    this.authenticationService.loading.set(true);
    // this.remote.signUp(firstName.value!, lastName.value!, emailOrPhone.value!, password.value!).pipe(
    //   tap(response => {
    //     this.authenticationService.errorMessage.set("")
    //     this.credentialsService.setCredentials(response.authentication);
    //     this.router.navigate(["/"]);
    //   }),
    //   catchError(err => {
    //     const errorMessage = getHttpErrorMessage(err);
    //     this.authenticationService.errorMessage.set(errorMessage)
    //     return throwError(() => err);
    //   })
    // ).subscribe()
  }
}
