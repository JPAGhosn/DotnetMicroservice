import { Routes } from '@angular/router';
import { authenticationRoute } from '@authentication/authenticationRoute';
import {guestGuard} from '@shared/guards/guest.guard';
import {userRoute} from './user/user.routes';

export const routes: Routes = [
  authenticationRoute,
  userRoute,
  {
    path: "**",
    redirectTo: "auth",
  },
];
