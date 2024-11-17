import {CanMatchFn, Router} from '@angular/router';
import {inject} from '@angular/core';
import {CredentialsService} from '@shared/services/credentials.service';

export const guestGuard: CanMatchFn = (route, segments) => {
  const credentialsService = inject(CredentialsService);
  const router = inject(Router);

  const credentials = credentialsService.credentials();

  if(credentials) {
    router.navigate(["user"]);
    return false;
  }

  return !credentials;
};
