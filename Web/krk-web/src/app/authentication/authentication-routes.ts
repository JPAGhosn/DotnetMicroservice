import {Route, Routes} from "@angular/router";
import {guestGuard} from '@shared/guards/guest.guard';

export const authenticationRoutes: Route = {
  path: "auth",
  loadComponent: () => import("./pages/authentication/authentication.component").then(m => m.AuthenticationComponent),
  canMatch: [guestGuard]
}
