import {inject, Injectable, signal, WritableSignal} from '@angular/core';
import {RecipeModel} from '../../home-page/models/recipe.model';
import {RecipeRemote} from '../remotes/recipe.remote';
import {tap} from 'rxjs';

@Injectable()
export class RecipePageService {
  recipe: WritableSignal<RecipeModel | null> = signal(null)

  recipesRemote = inject(RecipeRemote)

  fetch(recipeId: string) {
    return this.recipesRemote.get(recipeId).pipe(
      tap(recipe => {
        this.recipe.set(recipe)
      }),
    );
  }
}
