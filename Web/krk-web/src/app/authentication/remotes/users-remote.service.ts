import {HttpClient} from "@angular/common/http";
import {inject, Injectable} from "@angular/core";
import {environment} from "environments/environment";
import {map} from "rxjs";
import {CredentialsModel} from '@shared/models/credentials.model';
import {ProfileModel} from '../../user/components/side-bar/components/subscribtions/models/profile.model';
import {handleRemoteError} from '@shared/operators/handle-remote-error.operator';

@Injectable()
export class RemoteService {

  http = inject(HttpClient);

  checkUserExists(emailOrPhone: string) {
    return this.http.get<{ exists: boolean }>(`${environment.authApi}/users/check-user-exists/${emailOrPhone}`).pipe(
      map(response => response.exists)
    )
  }

  signIn(emailOrPhone: string, password: string) {
    return this.http.post<CredentialsModel>(`${environment.authApi}/sign-in`, {
      emailOrPhone: emailOrPhone,
      password: password
    })
  }

  signUp(firstName: string, lastName: string, emailOrPhone: string, password: string) {
    return this.http.post<{
      user: ProfileModel,
      authentication: CredentialsModel
    }>(`${environment.authApi}/sign-up`, {
      firstName,
      lastName,
      emailOrPhone,
      password
    }).pipe(handleRemoteError())
  }
}
