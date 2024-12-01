import {HttpInterceptorFn} from '@angular/common/http';
import {inject} from '@angular/core';
import {CredentialsService} from '@shared/services/credentials.service';
import {switchMap} from 'rxjs';

let isRequesting = false;

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const credentialsService = inject(CredentialsService)

  if (credentialsService.isTokenExpired() && !isRequesting) {
    isRequesting = true;
    return credentialsService.refreshToken().pipe(
      switchMap(response => {
        credentialsService.setCredentials(response)
        req = req.clone({
          setHeaders: {
            'Content-Type': 'application/json; charset=utf-8',
            'Accept': 'application/json',
            'Authorization': `Bearer ${response.access_token}`,
          },
        });

        return next(req)
      })
    )
  }

  req = req.clone({
    setHeaders: {
      'Content-Type': 'application/json; charset=utf-8',
      'Accept': 'application/json',
      'Authorization': `Bearer ${credentialsService.credentials()?.access_token ?? ""}`,
    },
  });
  return next(req);
};

