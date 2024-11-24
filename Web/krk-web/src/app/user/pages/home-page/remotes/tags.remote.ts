import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {TagModel} from '../models/tag.model';
import {PayloadHelper} from '@shared/helpers/payload.helper';

@Injectable()
export class TagsRemote {
  http = inject(HttpClient)
  payloadHelper = inject(PayloadHelper)

  fetch(props: { tagId: string } = {tagId: ""}) {
    const payload = this.payloadHelper.processQueryParams(props);

    const httpParams = new HttpParams({
      fromObject: payload
    })

    return this.http.get<TagModel[]>(environment.tagsApi, {
      params: httpParams
    });
  }
}
