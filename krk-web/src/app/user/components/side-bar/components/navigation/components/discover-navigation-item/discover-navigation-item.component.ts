import {Component, computed, inject} from '@angular/core';
import {DiscoverIconComponent} from "./components/discover-icon/discover-icon.component";
import {NavigationItemComponent} from "../../../navigation-item/navigation-item.component";
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-discover-navigation-item',
  standalone: true,
  imports: [
    DiscoverIconComponent,
    NavigationItemComponent
  ],
  templateUrl: './discover-navigation-item.component.html',
  styleUrl: './discover-navigation-item.component.scss'
})
export class DiscoverNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/discover", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["user", "discover"], {
      replaceUrl: true
    });
  }
}
