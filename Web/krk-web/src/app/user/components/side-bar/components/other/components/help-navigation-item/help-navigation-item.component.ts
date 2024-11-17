import {Component, computed, inject} from '@angular/core';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {HelpIconComponent} from './components/help-icon/help-icon.component';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-help-navigation-item',
  standalone: true,
  imports: [
    NavigationItemComponent,
    HelpIconComponent
  ],
  templateUrl: './help-navigation-item.component.html',
  styleUrl: './help-navigation-item.component.scss'
})
export class HelpNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/help", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["user", "help"], {
      replaceUrl: true
    });
  }
}
