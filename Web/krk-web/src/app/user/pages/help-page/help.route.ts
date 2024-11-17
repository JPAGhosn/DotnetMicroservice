import {Route} from '@angular/router';

export const helpRoute: Route = {
  path: 'help',
  loadComponent: () => import("./help-page.component").then(m => m.HelpPageComponent)
}
