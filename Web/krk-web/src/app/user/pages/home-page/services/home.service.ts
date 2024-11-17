import {inject, Injectable, Injector} from '@angular/core';
import {HomeRemote} from '../remotes/home.remote';
import {LoaderService} from '@shared/services/loader.service';
import {SubscriptionsStore} from '../../../stores/subscriptions.store';

@Injectable()
export class HomeService {
  remote = inject(HomeRemote)
  injector = inject(Injector)
  loaderService = inject(LoaderService)

  subscriptionsStore = inject(SubscriptionsStore)
}
