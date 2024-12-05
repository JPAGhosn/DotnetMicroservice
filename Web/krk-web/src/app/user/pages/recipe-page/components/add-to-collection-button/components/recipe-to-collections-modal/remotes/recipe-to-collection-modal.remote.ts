import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {environment} from '../../../../../../../../../environments/environment';
import {handleRemoteError} from '@shared/operators/handle-remote-error.operator';
import {PaginationResponse} from '@shared/response/pagination.response';
import {CollectionOwnerViewDto} from '../models/collection-owner-view.dto';

@Injectable()
export class RecipeToCollectionModalRemote {
  http = inject(HttpClient)

  fetchCollections(recipeId: string, options?: {
    search: string
  }) {
    const params = new HttpParams({
      fromObject: options
    })

    return this.http.get<PaginationResponse<CollectionOwnerViewDto>>(`${environment.collectionsApi}/collections-to-add-recipe/${recipeId}`, {
      params: params
    }).pipe(handleRemoteError())
  }
}
