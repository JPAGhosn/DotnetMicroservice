import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {RecipeModel} from '../models/recipe.model';

@Injectable()
export class RecipesRemote {
  http = inject(HttpClient);

  fetch(props: { tagId: string } = {tagId: ""}) {
    const httpParams = new HttpParams({
      fromObject: props
    })
    return this.http.get<RecipeModel[]>(`${environment.recipesApi}`, {
      params: httpParams
    });
  }
}
