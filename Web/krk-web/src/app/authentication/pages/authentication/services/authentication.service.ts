import { inject, Injectable, signal } from "@angular/core";
import { AuthenticationForm } from "../forms/authentication-form";
import { RemoteService } from "@authentication/remotes";
import { EMPTY } from "rxjs";

@Injectable()
export class AuthenticationService {

  form = inject(AuthenticationForm);
  remote = inject(RemoteService);

  loading = signal(false)
  errorMessage = signal("");
  emailLoading = signal(false)

  authenticationScreen = signal<"starter" | "sign-in" | "sign-up">("starter");

  checkUserExists() {
    const emailOrPhoneControl = this.form.formGroup.controls.emailOrPhone;

    if(emailOrPhoneControl.invalid) {
      return EMPTY;
    }

    const emailOrPhone = emailOrPhoneControl.value!;

    return this.remote.checkUserExists(emailOrPhone);
  }
}
