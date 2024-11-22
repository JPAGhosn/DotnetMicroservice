import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {GlimpseModel} from '../models/glimpse.model';

@Injectable()
export class GlimpsesRemote {
  http = inject(HttpClient);

  fetch(props: { tagId: string } = {tagId: ""}) {
    const httpParams = new HttpParams({
      fromObject: props
    })
    return this.http.get<GlimpseModel[]>(`${environment.glimpsesApi}`, {
      params: httpParams
    });
  }
}
