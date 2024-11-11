import {inject, Injectable, Injector} from '@angular/core';
import {HomeRemote} from '../remotes/home.remote';
import {tap} from 'rxjs';
import {LoaderService} from '@shared/services/loader.service';
import {notifyOnError} from '@shared/operators/notify-on-error.operator';
import {hideLoader} from '@shared/operators/hide-loader.operator';
import {SubscriptionsStore} from '../../../stores/subscriptions.store';

@Injectable()
export class HomeService {
  remote = inject(HomeRemote)
  injector = inject(Injector)
  loaderService = inject(LoaderService)

  subscriptionsStore = inject(SubscriptionsStore)

  fetch() {
    this.loaderService.show("HomeService/fetch")
    this.remote.fetch()
      .pipe(
        tap(response => {
        }),
        notifyOnError(this.injector),
        hideLoader(this.injector, "HomeService/fetch"),
      )
      .subscribe();
  }
}
