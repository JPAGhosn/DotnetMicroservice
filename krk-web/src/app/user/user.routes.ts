import {Route, Routes} from '@angular/router';
import {authGuard} from '@shared/guards/auth.guard';

export const userRoute: Route = {
  path: 'user',
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
