import {inject, Injectable, signal} from '@angular/core';
import {CredentialsModel} from '@shared/models/credentials.model';
import {CredentialsRemote} from '@shared/remotes/credentials.remote';
import {catchError, EMPTY, throwError} from 'rxjs';
import {jwtDecode} from "jwt-decode";
import {Router} from '@angular/router';

@Injectable()
export class CredentialsService {
  credentials = signal<CredentialsModel | null>(null)
  credentialsRemote = inject(CredentialsRemote)
  router = inject(Router)

  constructor() {
    this.setCredentials(JSON.parse(localStorage.getItem("credentials")!));
  }

  setCredentials(credentials: CredentialsModel) {
    localStorage.setItem('credentials', JSON.stringify(credentials));
    this.credentials.set(credentials);
  }

  refreshToken() {
    const refreshToken = this.credentials()?.refresh_token;
    if (!refreshToken) {
      return EMPTY;
    }
    return this.credentialsRemote.refreshToken(refreshToken).pipe(
      catchError(err => {
        this.credentials.set(null)
        this.router.navigate(['/']);
        return throwError(() => err)
      })
    );
  }

  // Check if token is expired
  isTokenExpired(): boolean {
    const accessToken = this.credentials()?.access_token;
    if (!accessToken) {
      return false;
    }
    const decoded: any = jwtDecode(accessToken);
    const currentTime = Math.floor(new Date().getTime() / 1000);
    return decoded.exp < currentTime;
  }

  clearTokens() {
    localStorage.removeItem('credentials');
    this.credentials.set(null)
  }
}
