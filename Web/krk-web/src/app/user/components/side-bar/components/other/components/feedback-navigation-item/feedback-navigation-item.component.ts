import {Component, computed, inject} from '@angular/core';
import {NavigationItemComponent} from '../../../navigation-item/navigation-item.component';
import {FeedbackIconComponent} from './components/feedback-icon/feedback-icon.component';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-feedback-navigation-item',
  standalone: true,
  imports: [
    NavigationItemComponent,
    FeedbackIconComponent
  ],
  templateUrl: './feedback-navigation-item.component.html',
  styleUrl: './feedback-navigation-item.component.scss'
})
export class FeedbackNavigationItemComponent {
  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive("/user/feedback", {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  navigate() {
    this.router.navigate(["user", "feedback"], {
      replaceUrl: true
    });
  }
}
