import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {handleRemoteError} from '@shared/operators/handle-remote-error.operator';

@Injectable()
export class RecipeRemote {
  http = inject(HttpClient);

  get(id: string) {
    return this.http.get(environment.recipesApi + "/" + id).pipe(handleRemoteError());
  }
}
