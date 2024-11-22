import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {CollectionModel} from '../models/collection.model';

@Injectable()
export class CollectionsRemote {
  http = inject(HttpClient);

  fetch(props: { tagId: string } = {tagId: ""}) {
    const httpParams = new HttpParams({
      fromObject: props
    })
    return this.http.get<CollectionModel[]>(`${environment.collectionsApi}`, {
      params: httpParams
    });
  }
}
