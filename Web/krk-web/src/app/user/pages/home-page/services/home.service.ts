import {inject, Injectable, Injector} from '@angular/core';
import {LoaderService} from '@shared/services/loader.service';
import {SubscriptionsStore} from '../../../stores/subscriptions.store';
import {RecipesRemote} from '../remotes/recipes.remote';
import {forkJoin, tap} from 'rxjs';
import {RecipesStore} from '../../../stores/recipes.store';

@Injectable()
export class HomeService {
  injector = inject(Injector)
  loaderService = inject(LoaderService)
  recipesRemote = inject(RecipesRemote)

  subscriptionsStore = inject(SubscriptionsStore)
  recipesStore = inject(RecipesStore)

  fetch() {
    return forkJoin({
      recipes: this.recipesRemote.fetch()
    }).pipe(
      tap(({recipes}) => {
        this.recipesStore.addMany(recipes)
      })
    )
  }
}
