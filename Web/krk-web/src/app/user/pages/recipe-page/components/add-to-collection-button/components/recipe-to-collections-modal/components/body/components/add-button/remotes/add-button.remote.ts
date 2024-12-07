import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../../../../../../../../../environments/environment';

@Injectable()
export class AddButtonRemote {
  http = inject(HttpClient)

  addToCollection(collectionId: string, recipeId: string) {
    return this.http.post(`${environment.collectionsApi}/${collectionId}/add-recipe`, {
      recipeId: recipeId
    })
  }

  removeFromCollection(collectionId: string, recipeId: string) {
    return this.http.post(`${environment.collectionsApi}/${collectionId}/remove-recipe`, {
      recipeId: recipeId
    })
  }
}
