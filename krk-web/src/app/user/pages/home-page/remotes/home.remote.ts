import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../../../environments/environment';

@Injectable()
export class HomeRemote {
  private http = inject(HttpClient);

  fetch() {
    const url = environment.apiUrl + "/home";
    return this.http.get(url);
  }
}
