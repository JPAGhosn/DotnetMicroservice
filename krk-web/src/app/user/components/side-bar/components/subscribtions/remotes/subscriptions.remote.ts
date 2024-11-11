import {inject} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../../../environments/environment';
import {SubscriptionModel} from '../models/subscription.model';

export class SubscriptionsRemote {
  http = inject(HttpClient)

  baseUrl = environment.apiUrl + "/subscriptions";

  fetch() {
    return this.http.get<SubscriptionModel[]>(this.baseUrl + "?limit=10")
  }
}
