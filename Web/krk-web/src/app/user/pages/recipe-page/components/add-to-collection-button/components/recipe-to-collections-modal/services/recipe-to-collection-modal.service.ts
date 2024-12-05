import {computed, inject, Injectable, signal} from '@angular/core';
import {RecipeToCollectionModalRemote} from '../remotes/recipe-to-collection-modal.remote';
import {catchError, finalize, tap, throwError} from 'rxjs';
import {BaseError} from '@shared/models/base/base-error';
import {CollectionsStore} from '../../../../../../../stores/collections.store';
import {RecipesStore} from '../../../../../../../stores/recipes.store';
import {RecipePageService} from '../../../../../services/recipe-page.service';
import {FormBuilder} from '@angular/forms';

@Injectable()
export class RecipeToCollectionModalService {
  collectionsStore = inject(CollectionsStore)
  recipesStore = inject(RecipesStore)
  remote = inject(RecipeToCollectionModalRemote);
  pageService = inject(RecipePageService);
  fb = inject(FormBuilder);

  searchControl = this.fb.control("");

  loading = signal(false);

  myCollectionsIds = signal<string[]>([]);

  chosenCollectionIds = signal<string[]>([])

  recipe = computed(() => {
    const recipeId = this.pageService.recipeId();
    if (!recipeId) return null;
    return this.recipesStore.data().find(recipe => recipe.id === recipeId)!;
  })

  myCollections = computed(() => {
    return this.collectionsStore.data().filter(collection => this.myCollectionsIds().includes(collection.id));
  });

  errorMessage = signal("");

  fetchCollections() {
    this.loading.set(true);
    return this.remote.fetchCollections(this.pageService.recipeId()!, {
      search: this.searchControl.value ?? "",
    }).pipe(
      tap(response => {
        this.errorMessage.set("");
        this.collectionsStore.addMany(response.data);
        this.myCollectionsIds.set(response.data.map(collection => collection.id));
        this.chosenCollectionIds.set(
          response.data.filter(collection => collection.isRecipeAdded)
            .map(collection => collection.id)
        );
      }),
      catchError(err => {
        const error = err as BaseError;
        this.errorMessage.set(error.description)
        return throwError(() => err)
      }),
      finalize(() => {
        this.loading.set(false)
      })
    );
  }
}
