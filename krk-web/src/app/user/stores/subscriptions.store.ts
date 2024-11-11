import {Injectable} from '@angular/core';
import {BaseDataStore} from '@shared/store/base/data-base.store';
import {SubscriptionModel} from '../components/side-bar/components/subscribtions/models/subscription.model';

@Injectable()
export class SubscriptionsStore extends BaseDataStore<SubscriptionModel> {

}
