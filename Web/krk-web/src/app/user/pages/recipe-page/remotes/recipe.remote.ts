import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {RecipeModel} from '../../home-page/models/recipe.model';

@Injectable()
export class RecipeRemote {
  http = inject(HttpClient);

  get(id: string) {
    return this.http.get<RecipeModel>(environment.recipesApi + "/" + id)
  }
}
