import {Route} from '@angular/router';

export const connectRoute: Route = {
  path: 'connect',
  loadComponent: () => import("../../pages/connect-page/connect-page.component").then(m => m.ConnectPageComponent),
};
