import {Component, computed, inject} from '@angular/core';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {SettingsIconComponent} from './components/settings-icon/settings-icon.component';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-settings-navigation-item',
  standalone: true,
  imports: [
    NavigationItemComponent,
    SettingsIconComponent
  ],
  templateUrl: './settings-navigation-item.component.html',
  styleUrl: './settings-navigation-item.component.scss'
})
export class SettingsNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/settings", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["user", "settings"], {
      replaceUrl: true
    });
  }
}
