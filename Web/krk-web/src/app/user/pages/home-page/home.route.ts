import {Route} from '@angular/router';

export const homeRoute: Route = {
  path: 'home',
  loadComponent: () => import("../../pages/home-page/home-page.component").then(m => m.HomePageComponent),
};
