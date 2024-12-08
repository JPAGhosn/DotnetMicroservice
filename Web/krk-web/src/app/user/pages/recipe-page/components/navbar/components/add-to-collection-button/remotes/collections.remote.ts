import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../../../../../environments/environment';

@Injectable()
export class CollectionsRemote {
  private http = inject(HttpClient)

  addRecipeToCollection(recipeId: string, collectionId: string) {
    return this.http.post(`${environment.collectionsApi}/add-recipe`, {
      recipeId: recipeId,
      collectionId: collectionId
    })
  }
}
