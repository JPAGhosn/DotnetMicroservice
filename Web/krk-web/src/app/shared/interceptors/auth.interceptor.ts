import {HttpInterceptorFn} from '@angular/common/http';
import {inject} from '@angular/core';
import {CredentialsService} from '@shared/services/credentials.service';
import {catchError, of, switchMap} from 'rxjs';
import {Router} from '@angular/router';

let isRequesting = false;

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const credentialsService = inject(CredentialsService);
  const router = inject(Router);

  if (credentialsService.isTokenExpired() && !isRequesting) {
    isRequesting = true;

    return credentialsService.refreshToken().pipe(
      switchMap(response => {
        credentialsService.setCredentials(response);
        isRequesting = false;

        // Clone the original request with updated token
        const clonedRequest = req.clone({
          setHeaders: {
            'Content-Type': 'application/json; charset=utf-8',
            'Accept': 'application/json',
            'Authorization': `Bearer ${response.access_token}`,
          },
        });

        // Retry the original request
        return next(clonedRequest);
      }),
      catchError(error => {
        isRequesting = false;
        // Handle refresh token errors (e.g., redirect to login)
        console.error('Token refresh failed', error);
        credentialsService.clearTokens();
        router.navigate(['/']);
        return of(error); // Or handle as appropriate
      })
    );
  }

  // Proceed with the original request if no refresh needed
  req = req.clone({
    setHeaders: {
      'Content-Type': 'application/json; charset=utf-8',
      'Accept': 'application/json',
      'Authorization': `Bearer ${credentialsService.credentials()?.access_token ?? ""}`,
    },
  });
  return next(req);
};
