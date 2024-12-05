import {computed, inject, Injectable, Injector, signal} from '@angular/core';
import {RecipeToCollectionModalRemote} from '../remotes/recipe-to-collection-modal.remote';
import {catchError, finalize, tap, throwError} from 'rxjs';
import {BaseError} from '@shared/models/base/base-error';
import {CollectionsStore} from '../../../../../../../stores/collections.store';
import {RecipesStore} from '../../../../../../../stores/recipes.store';
import {RecipePageService} from '../../../../../services/recipe-page.service';
import {FormBuilder} from '@angular/forms';
import {showSnackbarOnError} from '@shared/operators/show-snackbar-on-error.operator';

@Injectable()
export class RecipeToCollectionModalService {
  collectionsStore = inject(CollectionsStore)
  recipesStore = inject(RecipesStore)
  remote = inject(RecipeToCollectionModalRemote);
  pageService = inject(RecipePageService);
  fb = inject(FormBuilder);
  injector = inject(Injector);

  searchControl = this.fb.control("");

  loading = signal(false);

  firstCollectionMode = signal<"read" | "edit">("read")

  myCollectionsIds = signal<string[]>([]);

  chosenCollectionIds = signal<string[]>([])

  recipe = computed(() => {
    const recipeId = this.pageService.recipeId();
    if (!recipeId) return null;
    return this.recipesStore.data().find(recipe => recipe.id === recipeId)!;
  })

  myCollections = computed(() => {
    return this.myCollectionsIds().map(collectionId => this.collectionsStore.data().find(collection => collection.id === collectionId)!)
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

  createNewUnknownCollection() {
    const loaderId = "createNewUnknownCollection";
    this.loading.set(true);
    return this.remote.createCollection(this.recipe()!.id).pipe(
      tap(collection => {
        this.collectionsStore.addOne(collection);
        this.chosenCollectionIds.set([...this.chosenCollectionIds(), collection.id]);
        this.myCollectionsIds.set([collection.id, ...this.myCollectionsIds()]);
        this.firstCollectionMode.set("edit")
      }),
      showSnackbarOnError(this.injector),
      finalize(() => {
        this.loading.set(false);
      })
    )
  }

}
