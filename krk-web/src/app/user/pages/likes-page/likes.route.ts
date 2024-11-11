import {Route} from '@angular/router';

export const likesRoute: Route = {
  path: 'likes',
  loadComponent: () => import("../likes-page/likes-page.component").then(m => m.LikesPageComponent),
}
