import {inject, Injectable, Injector, signal} from '@angular/core';
import {LoaderService} from '@shared/services/loader.service';
import {SubscriptionsStore} from '../../../stores/subscriptions.store';
import {RecipesRemote} from '../remotes/recipes.remote';
import {forkJoin, tap} from 'rxjs';
import {RecipesStore} from '../../../stores/recipes.store';
import {TagsRemote} from '../remotes/tags.remote';
import {TagsStore} from '../../../stores/tags.store';
import {preventErrorPropagation} from '@shared/operators/prevent-error.operator';

@Injectable()
export class HomeService {
  injector = inject(Injector)
  loaderService = inject(LoaderService)
  recipesRemote = inject(RecipesRemote)
  tagsRemote = inject(TagsRemote)

  subscriptionsStore = inject(SubscriptionsStore)
  recipesStore = inject(RecipesStore)
  tagsStore = inject(TagsStore)

  // Used to filter the content of the page. Choose it from the top navbar
  filterTagId = signal<string>("");

  fetch() {
    return forkJoin({
      recipes: this.recipesRemote.fetch({tagId: this.filterTagId()}).pipe(preventErrorPropagation<any[]>([])),
      tags: this.tagsRemote.fetch().pipe(preventErrorPropagation<any[]>([])),
    }).pipe(
      tap(({recipes, tags}) => {
        this.recipesStore.addMany(recipes)
        this.tagsStore.addMany(tags)
      })
    )
  }
}
