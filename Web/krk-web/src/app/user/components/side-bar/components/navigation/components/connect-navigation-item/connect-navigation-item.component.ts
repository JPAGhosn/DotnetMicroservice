import {Component, computed, inject} from '@angular/core';
import {ConnectIconComponent} from './components/connect-icon/connect-icon.component';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-connect-navigation-item',
  standalone: true,
  imports: [
    ConnectIconComponent,
    NavigationItemComponent
  ],
  templateUrl: './connect-navigation-item.component.html',
  styleUrl: './connect-navigation-item.component.scss'
})
export class ConnectNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/connect", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["user", "connect"], {
      replaceUrl: true
    });
  }
}
