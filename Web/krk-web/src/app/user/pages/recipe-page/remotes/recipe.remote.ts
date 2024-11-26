import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {handleRemoteError} from '@shared/operators/handle-remote-error.operator';
import {RecipeModel} from '../../home-page/models/recipe.model';

@Injectable()
export class RecipeRemote {
  http = inject(HttpClient);

  get(id: string) {
    return this.http.get<RecipeModel>(environment.recipesApi + "/" + id).pipe(handleRemoteError());
  }
}
