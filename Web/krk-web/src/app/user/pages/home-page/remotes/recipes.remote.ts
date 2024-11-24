import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {RecipeModel} from '../models/recipe.model';
import {PayloadHelper} from '@shared/helpers/payload.helper';

@Injectable()
export class RecipesRemote {
  http = inject(HttpClient);
  payloadHelper = inject(PayloadHelper)

  fetch(props: { tagId: string, pageNumber: number, pageSize: number } = {tagId: "", pageNumber: 1, pageSize: 40}) {

    const payload = this.payloadHelper.processQueryParams(props);

    const httpParams = new HttpParams({
      fromObject: payload
    })
    
    return this.http.get<RecipeModel[]>(`${environment.recipesApi}`, {
      params: httpParams
    });
  }
}
