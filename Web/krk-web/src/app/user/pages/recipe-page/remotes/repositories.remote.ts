import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {RepositoryModel} from '../responses/repository.model';

@Injectable()
export class RepositoriesRemote {

  http = inject(HttpClient)

  get(recipeId: string, branchName: string) {
    return this.http.get<RepositoryModel>(`${environment.repositoriesApi}/${recipeId}/${branchName}`)
  }

}
