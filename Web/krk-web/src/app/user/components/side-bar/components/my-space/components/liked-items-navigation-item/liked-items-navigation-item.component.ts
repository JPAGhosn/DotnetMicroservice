import {Component, computed, inject} from '@angular/core';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {LikeIconComponent} from './components/like-icon/like-icon.component';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-liked-items-navigation-item',
  standalone: true,
  imports: [
    NavigationItemComponent,
    LikeIconComponent
  ],
  templateUrl: './liked-items-navigation-item.component.html',
  styleUrl: './liked-items-navigation-item.component.scss'
})
export class LikedItemsNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/likes", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["/user/likes"], {
      replaceUrl: true
    })
  }
}
