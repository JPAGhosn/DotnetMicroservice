import {ApplicationConfig, provideZoneChangeDetection} from '@angular/core';
import {provideRouter} from '@angular/router';

import {routes} from './app.routes';
import {provideAnimations} from '@angular/platform-browser/animations';
import {provideHttpClient, withInterceptors} from '@angular/common/http';
import {provideAnimationsAsync} from '@angular/platform-browser/animations/async';
import {CredentialsService} from '@shared/services/credentials.service';
import {CredentialsRemote} from '@shared/remotes/credentials.remote';
import {authInterceptor} from '@shared/interceptors/auth.interceptor';

export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({eventCoalescing: true}),
    provideRouter(routes),
    provideAnimations(),
    provideHttpClient(withInterceptors([authInterceptor])), provideAnimationsAsync(), provideAnimationsAsync(),
    CredentialsService,
    CredentialsRemote,

  ]
};
