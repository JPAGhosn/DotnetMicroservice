import {Route} from '@angular/router';

export const settingsRoute: Route = {
  path: 'settings',
  loadComponent: () => import("./settings-page.component").then(m => m.SettingsPageComponent)
}
