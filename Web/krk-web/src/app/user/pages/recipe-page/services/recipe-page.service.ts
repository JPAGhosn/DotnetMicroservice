import {inject, Injectable, signal, WritableSignal} from '@angular/core';
import {ProfileModel} from '../../../components/side-bar/components/subscribtions/models/profile.model';
import {RecipeModel} from '../../home-page/models/recipe.model';
import {RecipeRemote} from '../remotes/recipe.remote';
import {tap} from 'rxjs';

@Injectable()
export class RecipePageService {
  profile: WritableSignal<ProfileModel | null> = signal(null)
  recipe: WritableSignal<RecipeModel | null> = signal(null)

  recipesRemote = inject(RecipeRemote)

  fetch(recipeId: string) {
    return this.recipesRemote.get(recipeId).pipe(
      tap(recipe => {
      }),
    );
  }
}
