import {computed, DestroyRef, inject, Injectable, Injector, signal} from '@angular/core';
import {RecipeToCollectionModalRemote} from '../remotes/recipe-to-collection-modal.remote';
import {catchError, finalize, tap} from 'rxjs';
import {BaseError} from '@shared/models/base/base-error';
import {CollectionsStore} from '../../../../../../../../../stores/collections.store';
import {RecipesStore} from '../../../../../../../../../stores/recipes.store';
import {RecipePageService} from '../../../../../../../services/recipe-page.service';
import {FormBuilder} from '@angular/forms';
import {takeUntilDestroyed} from '@angular/core/rxjs-interop';

@Injectable()
export class RecipeToCollectionModalService {
  collectionsStore = inject(CollectionsStore)
  recipesStore = inject(RecipesStore)
  remote = inject(RecipeToCollectionModalRemote);
  pageService = inject(RecipePageService);
  fb = inject(FormBuilder);
  injector = inject(Injector);
  destroyRef = inject(DestroyRef)

  searchControl = this.fb.control("");

  createCollectionDisplayed = signal(false);

  loading = signal(false);

  // Message displayed in the center of the screen
  modalBodyMessage = signal("")

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

  fetchCollections() {
    this.loading.set(true);
    return this.remote.fetchCollections(this.pageService.recipeId()!, {
      search: this.searchControl.value ?? "",
    }).pipe(
      takeUntilDestroyed(this.destroyRef),
      tap(response => {
        this.modalBodyMessage.set("");
        if (response.data.length > 0) {
          this.modalBodyMessage.set("No collections")
        }
        this.collectionsStore.addMany(response.data);
        this.myCollectionsIds.set(response.data.map(collection => collection.id));
        this.chosenCollectionIds.set(
          response.data.filter(collection => collection.isRecipeAdded)
            .map(collection => collection.id)
        );
      }),
      catchError(err => {
        const error = err as BaseError;
        this.modalBodyMessage.set(error.description)
        throw err;
      }),
      finalize(() => {
        this.loading.set(false)
      })
    );
  }

  showCollectionCreateTemplate() {
    this.createCollectionDisplayed.set(true)
  }

  hideCollectionCreateTemplate() {
    this.createCollectionDisplayed.set(false)
  }

}
