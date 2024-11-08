import {Route, Routes} from '@angular/router';
import {authGuard} from '@shared/guards/auth.guard';
import {UserComponent} from './user.component';

export const userRoute: Route = {
  path: 'user',
  component: UserComponent,
  canMatch: [authGuard, ],
  children: [
    {
      path: 'home',
      loadComponent: () => import("./pages/home-page/home-page.component").then(m => m.HomePageComponent),
    },
    {
      path: '**',
      redirectTo: 'home',
    }
  ]
}
