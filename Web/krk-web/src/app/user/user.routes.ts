import {Route} from '@angular/router';
import {authGuard} from '@shared/guards/auth.guard';
import {UserComponent} from './user.component';
import {homeRoute} from './pages/home-page/home.route';
import {connectRoute} from './pages/connect-page/connect.route';
import {discoverRoute} from './pages/discover-page/discover.route';
import {mySpaceRoute} from './pages/my-space-page/my-space.route';
import {likesRoute} from './pages/likes-page/likes.route';
import {seeLaterRoute} from './pages/see-later-page/see-later.route';
import {collectionsRoute} from './pages/collections-page/collections.route';
import {settingsRoute} from './pages/settings-page/settings.route';
import {helpRoute} from './pages/help-page/help.route';
import {feedbackRoute} from './pages/feedback-page/feedback.route';

export const userRoute: Route = {
  path: 'user',
  component: UserComponent,
  canMatch: [authGuard,],
  children: [
    homeRoute,
    connectRoute,
    discoverRoute,
    mySpaceRoute,
    likesRoute,
    seeLaterRoute,
    collectionsRoute,
    settingsRoute,
    helpRoute,
    feedbackRoute,
    {
      path: '**',
      redirectTo: 'home',
    }
  ]
}
