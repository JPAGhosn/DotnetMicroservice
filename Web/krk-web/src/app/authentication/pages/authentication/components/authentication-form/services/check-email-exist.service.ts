import {inject, Injectable} from '@angular/core';
import {AuthenticationForm} from '@authentication/pages/authentication/forms/authentication-form';
import {AuthenticationService} from '@authentication/pages';
import {RemoteService} from '@authentication/remotes';
import {CredentialsService} from '@shared/services/credentials.service';
import {Router} from '@angular/router';
import {catchError, finalize, tap, throwError} from 'rxjs';
import {getHttpErrorMessage} from '@shared/helpers/get-http-error-message';

@Injectable()
export class CheckEmailExistService {
  form = inject(AuthenticationForm)
  authenticationService = inject(AuthenticationService)
  remote = inject(RemoteService)
  credentialsService = inject(CredentialsService)
  router = inject(Router)

  checkEmailExists() {
    console.log("checkEmailExists")
    this.authenticationService.emailLoading.set(true)
    this.authenticationService.checkUserExists().pipe(
      tap(exists => {
        this.authenticationService.errorMessage.set("");
        if (exists) {
          this.authenticationService.authenticationScreen.set("sign-in");
        } else {
          this.authenticationService.authenticationScreen.set("sign-up");
        }
      }),
      catchError(err => {
        const errorMessage = getHttpErrorMessage(err);
        this.authenticationService.errorMessage.set(errorMessage);
        return throwError(() => err)
      }),
      finalize(() => {
        this.authenticationService.emailLoading.set(false)
      })
    ).subscribe();
  }
}
