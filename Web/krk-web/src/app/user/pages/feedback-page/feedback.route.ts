import {Route} from '@angular/router';

export const feedbackRoute: Route = {
  path: 'feedback',
  loadComponent: () => import("./feedback-page.component").then(m => m.FeedbackPageComponent)
}
