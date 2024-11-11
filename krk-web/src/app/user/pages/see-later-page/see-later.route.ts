import {Route} from '@angular/router';

export const seeLaterRoute: Route = {
  path: 'see-later',
  loadComponent: () => import("./see-later-page.component").then(m => m.SeeLaterPageComponent)
}
