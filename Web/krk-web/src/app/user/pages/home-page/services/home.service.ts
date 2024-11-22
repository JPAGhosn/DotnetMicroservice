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

@Injectable()
export class HomeService {
  injector = inject(Injector)
  loaderService = inject(LoaderService)
  recipesRemote = inject(RecipesRemote)
  tagsRemote = inject(TagsRemote)
  glimpsesRemote = inject(GlimpsesRemote)

  subscriptionsStore = inject(SubscriptionsStore)
  recipesStore = inject(RecipesStore)
  tagsStore = inject(TagsStore)
  glimpsesStore = inject(GlimpsesStore)

  // Used to filter the content of the page. Choose it from the top navbar
  filterTagId = signal<string>("");

  fetch() {
    return forkJoin({
      recipes: this.recipesRemote.fetch({tagId: this.filterTagId()}).pipe(preventErrorPropagation<RecipeModel[]>([])),
      tags: this.tagsRemote.fetch().pipe(preventErrorPropagation<TagModel[]>([])),
      glimpses: this.glimpsesRemote.fetch().pipe(preventErrorPropagation<GlimpseModel[]>([])),
    }).pipe(
      tap(({recipes, tags, glimpses}) => {
        this.recipesStore.addMany(recipes)
        this.tagsStore.addMany(tags)
        this.glimpsesStore.addMany(glimpses)
      })
    )
  }
}
