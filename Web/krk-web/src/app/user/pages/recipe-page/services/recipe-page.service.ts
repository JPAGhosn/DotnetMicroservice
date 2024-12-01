import {computed, inject, Injectable, signal} from '@angular/core';
import {RecipeRemote} from '../remotes/recipe.remote';
import {tap} from 'rxjs';
import {RecipesStore} from '../../../stores/recipes.store';

@Injectable()
export class RecipePageService {
  recipeId = signal<string | null>(null);
  recipesStore = inject(RecipesStore)
  recipe = computed(() => {
    return this.recipesStore.data().find(recipe => recipe.id === this.recipeId())
  });
  recipesRemote = inject(RecipeRemote)

  fetch(recipeId: string) {
    return this.recipesRemote.get(recipeId).pipe(
      tap(recipe => {
        this.recipesStore.addOne(recipe);
        this.recipeId.set(recipeId)
      }),
    );
  }
}
