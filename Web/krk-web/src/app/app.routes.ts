import { Routes } from '@angular/router';
import { authenticationRoutes } from '@authentication/authentication-routes';
import {guestGuard} from '@shared/guards/guest.guard';
import {userRoute} from './user/user.routes';

export const routes: Routes = [
  authenticationRoutes,
  userRoute,
  {
    path: "**",
    redirectTo: "auth",
  },
];
