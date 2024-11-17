import {Component, computed, inject} from '@angular/core';
import {MySpaceIconComponent} from './components/my-space-icon/my-space-icon.component';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {toSignal} from '@angular/core/rxjs-interop';
import {Router} from '@angular/router';

@Component({
  selector: 'krk-my-space-navigation-item',
  standalone: true,
  imports: [
    MySpaceIconComponent,
    NavigationItemComponent
  ],
  templateUrl: './my-space-navigation-item.component.html',
  styleUrl: './my-space-navigation-item.component.scss'
})
export class MySpaceNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/my-space", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["user", "my-space"], {
      replaceUrl: true
    });
  }
}
