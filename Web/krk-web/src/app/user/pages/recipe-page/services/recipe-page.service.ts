import {computed, inject, Injectable, signal} from '@angular/core';
import {RecipeRemote} from '../remotes/recipe.remote';
import {tap} from 'rxjs';
import {RecipesStore} from '../../../stores/recipes.store';
import {RepositoriesRemote} from '../remotes/repositories.remote';
import {RepositoriesStore} from '../../../stores/repositories.store';

@Injectable()
export class RecipePageService {
  recipeId = signal<string | null>(null);
  branchName = signal<string>("main");
  fileName = signal<string | null>(null);
  recipesStore = inject(RecipesStore)
  repositoriesStore = inject(RepositoriesStore);
  repositoryId = signal<string | null>(null);

  editMode = signal(false)

  recipe = computed(() => {
    return this.recipesStore.data().find(recipe => recipe.id === this.recipeId())
  });

  recipesRemote = inject(RecipeRemote)
  repositoriesRemote = inject(RepositoriesRemote)

  fetchRecipe(recipeId: string) {
    return this.recipesRemote.get(recipeId).pipe(
      tap(recipe => {
        this.recipesStore.addOne(recipe);
        this.recipeId.set(recipeId)
      }),
    );
  }

  fetchRepository(recipeId: string) {
    return this.repositoriesRemote.get(recipeId, this.branchName()).pipe(
      tap(recipeRepositoryInformation => {
        this.repositoriesStore.addOne(recipeRepositoryInformation);
      })
    )
  }
}
