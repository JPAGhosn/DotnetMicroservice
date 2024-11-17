import {Component, computed, inject} from '@angular/core';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {CollectionsIconComponent} from './components/collections-icon/collections-icon.component';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-collections-navigation-item',
  standalone: true,
  imports: [
    NavigationItemComponent,
    CollectionsIconComponent
  ],
  templateUrl: './collections-navigation-item.component.html',
  styleUrl: './collections-navigation-item.component.scss'
})
export class CollectionsNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/collections", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["/user/collections"], {
      replaceUrl: true
    })
  }
}
