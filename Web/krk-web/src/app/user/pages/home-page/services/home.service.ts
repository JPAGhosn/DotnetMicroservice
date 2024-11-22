import {inject, Injectable, Injector, signal} from '@angular/core';
import {LoaderService} from '@shared/services/loader.service';
import {SubscriptionsStore} from '../../../stores/subscriptions.store';
import {RecipesRemote} from '../remotes/recipes.remote';
import {forkJoin, tap} from 'rxjs';
import {RecipesStore} from '../../../stores/recipes.store';
import {TagsRemote} from '../remotes/tags.remote';
import {TagsStore} from '../../../stores/tags.store';
import {preventErrorPropagation} from '@shared/operators/prevent-error.operator';
import {RecipeModel} from '../models/recipe.model';
import {TagModel} from '../models/tag.model';
import {GlimpsesRemote} from '../remotes/glimpses.remote';
import {GlimpseModel} from '../models/glimpse.model';
import {GlimpsesStore} from '../../../stores/glimpses.store';
import {CollectionModel} from '../models/collection.model';
import {CollectionsStore} from '../../../stores/collections.store';
import {CollectionsRemote} from '../remotes/collections.remote';

@Injectable()
export class HomeService {
  injector = inject(Injector)
  loaderService = inject(LoaderService)
  recipesRemote = inject(RecipesRemote)
  tagsRemote = inject(TagsRemote)
  glimpsesRemote = inject(GlimpsesRemote)
  collectionsRemote = inject(CollectionsRemote)

  subscriptionsStore = inject(SubscriptionsStore)
  recipesStore = inject(RecipesStore)
  tagsStore = inject(TagsStore)
  glimpsesStore = inject(GlimpsesStore)
  collectionsStore = inject(CollectionsStore)

  // Used to filter the content of the page. Choose it from the top navbar
  filterTagId = signal<string>("");

  fetch() {
    return forkJoin({
      recipes: this.recipesRemote.fetch({tagId: this.filterTagId()}).pipe(preventErrorPropagation<RecipeModel[]>([])),
      tags: this.tagsRemote.fetch().pipe(preventErrorPropagation<TagModel[]>([])),
      glimpses: this.glimpsesRemote.fetch().pipe(preventErrorPropagation<GlimpseModel[]>([])),
      collections: this.collectionsRemote.fetch().pipe(preventErrorPropagation<CollectionModel[]>([])),
    }).pipe(
      tap(({recipes, tags, glimpses, collections}) => {
        this.recipesStore.addMany(recipes)
        this.tagsStore.addMany(tags)
        this.glimpsesStore.addMany(glimpses)
        this.collectionsStore.addMany(collections)
      })
    )
  }
}
