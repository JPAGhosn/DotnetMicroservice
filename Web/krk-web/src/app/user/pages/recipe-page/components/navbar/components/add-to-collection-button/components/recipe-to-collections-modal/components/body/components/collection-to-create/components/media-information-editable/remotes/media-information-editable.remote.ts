import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../../../../../../../../../../../../../environments/environment';

@Injectable()
export class MediaInformationEditableRemote {
  http = inject(HttpClient)

  createCollection(recipeId: string, name: string) {
    return this.http.post<{ id: string }>(`${environment.collectionsApi}/create-simple-to-add-to-recipe/${recipeId}`, {
      name: name
    })
  }
}
