import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {RecipeModel} from '../../../components/side-bar/components/subscribtions/models/recipe.model';

@Injectable()
export class RecipesRemote {
  http = inject(HttpClient);

  fetch() {
    return this.http.get<RecipeModel[]>(`${environment.recipesApi}`);
  }
}
