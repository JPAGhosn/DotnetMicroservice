import {Component, computed, inject} from '@angular/core';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {SeeLaterIconComponent} from './components/see-later-icon/see-later-icon.component';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-see-later-navigation-item',
  standalone: true,
  imports: [
    NavigationItemComponent,
    SeeLaterIconComponent
  ],
  templateUrl: './see-later-navigation-item.component.html',
  styleUrl: './see-later-navigation-item.component.scss'
})
export class SeeLaterNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/see-later", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["/user/see-later"], {
      replaceUrl: true
    })
  }
}
