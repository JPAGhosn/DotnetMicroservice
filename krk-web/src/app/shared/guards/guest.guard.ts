import { CanMatchFn } from '@angular/router';
import {inject} from '@angular/core';
import {CredentialsService} from '@shared/services/credentials.service';

export const guestGuard: CanMatchFn = (route, segments) => {
  const credentialsService = inject(CredentialsService);
  const credentials = credentialsService.credentials();

  return !credentials;
};
