import {inject, Injectable, Injector, signal} from '@angular/core';
import {SubscriptionsStore} from '../../../../../stores/subscriptions.store';
import {SubscriptionsRemote} from '../remotes/subscriptions.remote';
import {hideLoader} from '@shared/operators/hide-loader.operator';
import {generateUUID} from '@shared/helpers/uuid';
import {LoaderService} from '@shared/services/loader.service';
import {notifyOnError} from '@shared/operators/notify-on-error.operator';
import {tap} from 'rxjs';

@Injectable()
export class SubscriptionsService {
  injector = inject(Injector)
  subscriptionsRemote = inject(SubscriptionsRemote)
  subscriptionsStore = inject(SubscriptionsStore)
  loaderService = inject(LoaderService)

  expanded = signal(false)

  fetch() {
    const loaderId = generateUUID()
    this.loaderService.show(loaderId)
    this.subscriptionsRemote.fetch().pipe(
      tap(subscriptions => {
        this.subscriptionsStore.addMany(subscriptions);
      }),
      notifyOnError(this.injector),
      hideLoader(this.injector, loaderId)
    ).subscribe()
  }
}
