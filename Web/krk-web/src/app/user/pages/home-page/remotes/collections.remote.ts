import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {CollectionModel} from '../models/collection.model';
import {PayloadHelper} from '@shared/helpers/payload.helper';
import {handleRemoteError} from '@shared/operators/handle-remote-error.operator';

@Injectable()
export class CollectionsRemote {
  http = inject(HttpClient);
  payloadHelper = inject(PayloadHelper)

  fetch(props: { tagId: string } = {tagId: ""}) {
    const payload = this.payloadHelper.processQueryParams(props);

    const httpParams = new HttpParams({
      fromObject: payload
    })
    return this.http.get<CollectionModel[]>(`${environment.collectionsApi}`, {
      params: httpParams
    }).pipe(handleRemoteError());
  }
}
