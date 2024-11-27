import {inject, Injectable} from '@angular/core';
import {CollectionsRemote} from '../remotes/collections.remote';
import {RecipePageService} from '../../../services/recipe-page.service';

@Injectable()
export class CollectionsService {
  remote = inject(CollectionsRemote)
  recipePageService = inject(RecipePageService)

  addRecipeToCollection(collectionId: string) {
    const recipeId = this.recipePageService.recipe()?.id!;
    return this.remote.addRecipeToCollection(recipeId, collectionId);
  }
}
