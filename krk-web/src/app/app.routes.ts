import { Routes } from '@angular/router';
import { authenticationRoutes } from './authentication/authentication.routes';

export const routes: Routes = [
    ...authenticationRoutes,
  {
    path: "**",
    redirectTo: "auth"
  },
];
