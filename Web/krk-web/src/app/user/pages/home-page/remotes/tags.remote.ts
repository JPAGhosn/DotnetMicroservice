import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';
import {TagModel} from '../models/tag.model';

@Injectable()
export class TagsRemote {
  http = inject(HttpClient)

  fetch() {
    return this.http.get<TagModel[]>(environment.tagsApi);
  }
}
