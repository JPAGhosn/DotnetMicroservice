import {Component, inject} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {SubscriptionsService} from '../../services/subscriptions.service';

@Component({
  selector: 'krk-show-more-button',
  standalone: true,
  imports: [
    NgOptimizedImage
  ],
  templateUrl: './show-more-button.component.html',
  styleUrl: './show-more-button.component.scss'
})
export class ShowMoreButtonComponent {
  subscriptionsService = inject(SubscriptionsService)

  toggleExpandCollapse() {
    const expanded = this.subscriptionsService.expanded
    expanded.set(!expanded())
  }
}
