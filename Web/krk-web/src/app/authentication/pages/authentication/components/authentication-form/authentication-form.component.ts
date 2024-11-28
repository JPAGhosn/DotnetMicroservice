import {Component, computed, effect, ElementRef, inject, signal, ViewChild} from '@angular/core';
import {ConfirmPasswordInputComponent, EmailInputComponent, PasswordInputComponent} from './components';
import {AuthenticationForm} from '../../forms/authentication-form';
import {ReactiveFormsModule} from '@angular/forms';
import {AuthenticationService} from '@authentication/pages';
import {
  SubmitButtonComponent
} from '@authentication/pages/authentication/components/authentication-form/components/submit-button/submit-button.component';
import {catchError, finalize, tap, throwError} from 'rxjs';
import {RemoteService} from '@authentication/remotes';
import {getHttpErrorMessage} from '@shared/helpers/get-http-error-message';
import {HttpErrorResponse} from '@angular/common/http';
import {CredentialsService} from '@shared/services/credentials.service';
import {Router} from '@angular/router';
import {
  FirstNameInputComponent
} from '@authentication/pages/authentication/components/authentication-form/components/first-name-input/first-name-input.component';
import {
  LastNameInputComponent
} from '@authentication/pages/authentication/components/authentication-form/components/last-name-input/last-name-input.component';

@Component({
  selector: 'krk-authentication-form',
  standalone: true,
  imports: [EmailInputComponent, PasswordInputComponent, ConfirmPasswordInputComponent, ReactiveFormsModule, SubmitButtonComponent, FirstNameInputComponent, LastNameInputComponent],
  templateUrl: './authentication-form.component.html',
  styleUrl: './authentication-form.component.scss',
})
export class AuthenticationFormComponent {
  service = inject(AuthenticationService)
  form = inject(AuthenticationForm)
  remote = inject(RemoteService)
  credentialsService = inject(CredentialsService)
  router = inject(Router);

  @ViewChild("password") passwordElementRef!: ElementRef;
  @ViewChild("confirmPassword") confirmPasswordElementRef!: ElementRef;

  errorMessage = signal("");
  emailLoading = signal(false)
  loading = signal(false)
  passwordVisible = computed(() => {
    const screen = this.service.authenticationScreen();
    return ["sign-up", "sign-in"].includes(screen)
  })
  confirmPasswordVisible = computed(() => {
    const screen = this.service.authenticationScreen();
    return ["sign-up"].includes(screen)
  })
  userInformationVisible = computed(() => {
    const screen = this.service.authenticationScreen();
    return ["sign-up"].includes(screen)
  })
  submitButtonVisible = computed(() => {
    const screen = this.service.authenticationScreen();
    return ["sign-up", "sign-in"].includes(screen)
  })

  constructor() {
    effect(() => {

      const screen = this.service.authenticationScreen();

      const emailDisabled = ["sign-up", "sign-in"].includes(screen);

      if (emailDisabled) {
        this.form.formGroup.controls.emailOrPhone.disable();
      } else {
        this.form.formGroup.controls.emailOrPhone.enable();
      }
    });
  }

  onSubmit() {
    const screen = this.service.authenticationScreen();
    switch (screen) {
      case "sign-in":
        console.log("Sign In")
        this.signIn();
        break;
      case "sign-up":
        this.signUp();
        break;
      case "starter":
        this.checkEmailExists();
        break;
      default:
        throw "Screen not handled";
    }
  }

  checkEmailExists() {
    console.log("checkEmailExists")
    this.emailLoading.set(true)
    this.service.checkUserExists().pipe(
      tap(exists => {
        this.errorMessage.set("");
        if (exists) {
          this.service.authenticationScreen.set("sign-in");
        } else {
          this.service.authenticationScreen.set("sign-up");
        }
      }),
      catchError(err => {
        const errorMessage = getHttpErrorMessage(err);
        this.errorMessage.set(errorMessage);
        return throwError(() => err)
      }),
      finalize(() => {
        this.emailLoading.set(false)
      })
    ).subscribe();
  }

  signIn() {
    const emailOrPhoneControl = this.form.formGroup.controls.emailOrPhone;
    const passwordControl = this.form.formGroup.controls.password;

    emailOrPhoneControl.markAsTouched();
    passwordControl.markAsTouched();

    if (emailOrPhoneControl.invalid || passwordControl.invalid) {
      return;
    }

    const emailOrPhone = emailOrPhoneControl.value!;
    const password = passwordControl.value!;

    this.loading.set(true)
    this.remote.signIn(emailOrPhone, password).pipe(
      tap(response => {
        this.errorMessage.set("")
        this.credentialsService.setCredentials(response);
        this.router.navigate(["/"]);
      }),
      catchError((err: HttpErrorResponse) => {
        if (err.status === 401) {
          this.errorMessage.set("Wrong email or password");
        } else {
          const errorMessage = getHttpErrorMessage(err);
          this.errorMessage.set(errorMessage)
        }
        return throwError(() => err);
      }),
      finalize(() => {
        this.loading.set(false);
      })
    ).subscribe();
  }

  signUp() {
    const {firstName, lastName, emailOrPhone, password} = this.form.formGroup.controls;
    if (firstName.invalid || lastName.invalid || emailOrPhone.invalid || password.invalid) {
      return;
    }

    this.loading.set(true);
    this.remote.signUp(firstName.value!, lastName.value!, emailOrPhone.value!, password.value!).pipe(
      tap(response => {
        this.errorMessage.set("")
        this.credentialsService.setCredentials(response.authentication);
        this.router.navigate(["/"]);
      }),
      catchError(err => {
        const errorMessage = getHttpErrorMessage(err);
        this.errorMessage.set(errorMessage)
        return throwError(() => err);
      })
    ).subscribe()
  }
}
