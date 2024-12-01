import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../../../../../../../../../../../environments/environment';
import {handleRemoteError} from '@shared/operators/handle-remote-error.operator';

@Injectable()
export class AddButtonRemote {
  http = inject(HttpClient)

  addToCollection(collectionId: string, recipeId: string) {
    return this.http.post(`${environment.collectionsApi}/${collectionId}/add-recipe`, {
      recipeId: recipeId
    }).pipe(handleRemoteError())
  }

  removeFromCollection(collectionId: string, recipeId: string) {
    return this.http.post(`${environment.collectionsApi}/${collectionId}/remove-recipe`, {
      recipeId: recipeId
    }).pipe(handleRemoteError())
  }
}
