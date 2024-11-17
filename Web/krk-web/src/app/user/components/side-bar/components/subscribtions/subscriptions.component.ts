import {Component, computed, inject, OnInit} from '@angular/core';
import {TitleComponent} from '../title/title.component';
import {SubscriptionComponent} from './components/subscribtion/subscription.component';
import {ShowMoreButtonComponent} from './components/show-more-button/show-more-button.component';
import {SubscriptionsStore} from '../../../../stores/subscriptions.store';
import {SubscriptionsService} from './services/subscriptions.service';
import {SubscriptionsRemote} from './remotes/subscriptions.remote';

@Component({
  selector: 'krk-subscribtions',
  standalone: true,
  imports: [
    TitleComponent,
    SubscriptionComponent,
    ShowMoreButtonComponent
  ],
  templateUrl: './subscriptions.component.html',
  styleUrl: './subscriptions.component.scss',
  providers: [
    SubscriptionsService,
    SubscriptionsRemote,
  ]
})
export class SubscriptionsComponent implements OnInit {
  subscriptionsStore = inject(SubscriptionsStore)
  subscriptionsService = inject(SubscriptionsService)

  subscriptions = computed(() => {
    const subscriptions = this.subscriptionsStore.data();

    if (subscriptions.length < 5) {
      return subscriptions;
    }

    return subscriptions.slice(0, 5);
  });

  showMoreButtonVisible = computed(() => {
    const subscriptions = this.subscriptionsStore.data();
    return subscriptions.length > 5
  })


  ngOnInit() {
    this.subscriptionsService.fetch()
  }
}
