import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class HomeRemote {
  private http = inject(HttpClient);
}
