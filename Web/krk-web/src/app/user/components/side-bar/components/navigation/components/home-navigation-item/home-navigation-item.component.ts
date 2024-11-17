import {Component, computed, inject} from '@angular/core';
import {HomeIconComponent} from "./components/home-icon/home-icon.component";
import {NavigationItemComponent} from "../../../navigation-item/navigation-item.component";
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-home-navigation-item',
  standalone: true,
  imports: [
    HomeIconComponent,
    NavigationItemComponent
  ],
  templateUrl: './home-navigation-item.component.html',
  styleUrl: './home-navigation-item.component.scss'
})
export class HomeNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/home", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["user", "home"], {
      replaceUrl: true
    });
  }
}
