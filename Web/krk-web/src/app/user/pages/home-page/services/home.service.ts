import {computed, inject, Injectable, Injector, signal, WritableSignal} from '@angular/core';
import {LoaderService} from '@shared/services/loader.service';
import {SubscriptionsStore} from '../../../stores/subscriptions.store';
import {RecipesRemote} from '../remotes/recipes.remote';
import {catchError, EMPTY, forkJoin, of, tap, throwError} from 'rxjs';
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
import {emptyPaginationResponse, PaginationResponse} from '@shared/response/pagination.response';

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

  pageNumber = signal(1);
  totalPages = signal(1);
  pageSize = 6 * 6;

  tagsLoaded = signal(false);

  recipesIds: WritableSignal<string[]> = signal([]);
  glimpsesIds: WritableSignal<string[]> = signal([]);
  collectionsIds: WritableSignal<string[]> = signal([]);

  recipes = computed(() => {
    const ids = this.recipesIds();
    const data = this.recipesStore.data();
    return ids.map(id => data.find(recipe => recipe.id === id)!);
  })

  glimpses = computed(() => {
    const ids = this.glimpsesIds();
    const data = this.glimpsesStore.data();
    return ids.map(id => data.find(glimpse => glimpse.id === id)!);
  })

  collections = computed(() => {
    const ids = this.collectionsIds();
    const data = this.collectionsStore.data();
    return ids.map(id => data.find(collection => collection.id === id)!);
  })

  fetchAll() {
    this.pageNumber.set(1);

    return forkJoin({
      recipes: this.recipesRemote.fetch({
        tagId: this.filterTagId(),
        pageNumber: this.pageNumber(),
        pageSize: this.pageSize
      }).pipe(preventErrorPropagation<PaginationResponse<RecipeModel>>(emptyPaginationResponse<RecipeModel>(this.pageNumber(), this.pageSize))),

      // Prevent loading the tags twice
      tags: this.tagsLoaded() ? of([]) : this.tagsRemote.fetch({tagId: this.filterTagId(),}).pipe(preventErrorPropagation<TagModel[]>([])),

      glimpses: this.glimpsesRemote.fetch({tagId: this.filterTagId(),}).pipe(preventErrorPropagation<GlimpseModel[]>([])),

      collections: this.collectionsRemote.fetch({tagId: this.filterTagId(),}).pipe(preventErrorPropagation<CollectionModel[]>([])),
    }).pipe(
      tap(({recipes, tags, glimpses, collections}) => {
        this.tagsStore.addMany(tags)
        this.tagsLoaded.set(true)

        this.recipesStore.addMany(recipes.data);
        this.recipesIds.set(recipes.data.map(recipe => recipe.id));
        this.totalPages.set(recipes.totalPages)

        this.glimpsesStore.addMany(glimpses)
        this.glimpsesIds.set(glimpses.map(glimpse => glimpse.id));

        this.collectionsStore.addMany(collections)
        this.collectionsIds.set(collections.map(collection => collection.id));
      })
    )
  }

  fetchMoreRecipes() {
    if (this.pageNumber() >= this.totalPages()) {
      return EMPTY;
    }

    this.pageNumber.set(this.pageNumber() + 1);

    return this.recipesRemote.fetch({
      tagId: this.filterTagId(),
      pageNumber: this.pageNumber(),
      pageSize: this.pageSize
    }).pipe(
      tap(recipes => {
        if (recipes.data.length <= 0) {
          this.pageNumber.set(this.pageNumber() - 1);
          return;
        }

        this.recipesStore.addMany(recipes.data);
        let recipesIds = [...this.recipesIds()];
        const newRecipesIds = recipes.data.map(recipe => recipe.id)
        recipesIds = [
          ...recipesIds,
          ...newRecipesIds
        ];
        this.recipesIds.set(recipesIds);

      }),
      catchError(err => {
        this.pageNumber.set(this.pageNumber() - 1);
        return throwError(() => err);
      })
    )
  }

}
