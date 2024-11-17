import {Injectable, signal} from '@angular/core';
import {CredentialsModel} from '@shared/models/credentials.model';

@Injectable()
export class CredentialsService {
  credentials = signal<CredentialsModel | null>(null)

  constructor() {
    this.setCredentials(JSON.parse(localStorage.getItem("credentials")!));
  }

  setCredentials(credentials: CredentialsModel) {
    localStorage.setItem('credentials', JSON.stringify(credentials));
    this.credentials.set(credentials);
  }
}
