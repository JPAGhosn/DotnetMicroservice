import { HttpClient } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { environment } from "environments/environment";
import { delay, map } from "rxjs";
import {CredentialsModel} from '@shared/models/credentials.model';

@Injectable()
export class RemoteService {
  baseUrl = environment.apiUrl + "/users";

  http = inject(HttpClient);

  checkUserExists(emailOrPhone: string) {
    return this.http.get<{ exists: boolean }>(`${environment.apiUrl}/users/check-user-exists/${emailOrPhone}`).pipe(
      map(response => response.exists)
    )
  }

  signIn(emailOrPhone: string, password: string) {
    return this.http.post<CredentialsModel>(`${environment.apiUrl}/auth/sign-in`, {
      emailOrPhone: emailOrPhone,
      password: password
    })
  }
}
