import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../environments/environment';
import {CredentialsModel} from '@shared/models/credentials.model';

@Injectable()
export class CredentialsRemote {
  http = inject(HttpClient)

  refreshToken(refreshToken: string) {
    return this.http.post<CredentialsModel>(`${environment.authApi}/refresh-token`, {
      refreshToken: refreshToken,
    })
  }
}
