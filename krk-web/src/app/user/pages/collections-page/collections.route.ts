import {Route} from '@angular/router';

export const collectionsRoute: Route = {
  path: 'collections',
  loadComponent: () => import("../collections-page/collections-page.component").then(m => m.CollectionsPageComponent),
}
