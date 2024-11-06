import {Component, computed, effect, ElementRef, inject, signal, ViewChild} from '@angular/core';
import { ConfirmPasswordInputComponent, EmailInputComponent, PasswordInputComponent } from './components';
import { AuthenticationForm } from '../../forms/authentication-form';
import { ReactiveFormsModule } from '@angular/forms';
import { AuthenticationService } from '@authentication/pages';
import {
  SubmitButtonComponent
} from '@authentication/pages/authentication/components/authentication-form/components/submit-button/submit-button.component';
import {catchError, finalize, tap, throwError} from 'rxjs';
import {RemoteService} from '@authentication/remotes';
import {ErrorModel, isErrorModel} from '@shared/models/error.model';
import {isString} from '@shared/helpers/is-string';
import {getHttpErrorMessage} from '@shared/helpers/get-http-error-message';

@Component({
  selector: 'krk-authentication-form',
  standalone: true,
  imports: [EmailInputComponent, PasswordInputComponent, ConfirmPasswordInputComponent, ReactiveFormsModule, SubmitButtonComponent],
  templateUrl: './authentication-form.component.html',
  styleUrl: './authentication-form.component.scss',
})
export class AuthenticationFormComponent {
  service = inject(AuthenticationService)
  form = inject(AuthenticationForm)
  remote = inject(RemoteService)

  @ViewChild("password") passwordElementRef!: ElementRef;
  @ViewChild("confirmPassword") confirmPasswordElementRef!: ElementRef;

  errorMessage = signal("");
  emailLoading = signal(false)
  loading = signal(false)

  constructor() {
    effect(() => {

      const screen = this.service.authenticationScreen();

      const emailDisabled = ["sign-up", "sign-in"].includes(screen);

      if(emailDisabled) {
        this.form.formGroup.controls.emailOrPhone.disable();
      }
      else {
        this.form.formGroup.controls.emailOrPhone.enable();
      }
    });
  }

  onSubmit() {
    console.log("Submit")
    const screen = this.service.authenticationScreen();
    switch (screen) {
      case "sign-in":
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
        if(exists) {
          this.service.authenticationScreen.set("sign-in");
        }
        else {
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
    this.form.formGroup.markAsTouched();

    const emailOrPhoneControl = this.form.formGroup.controls.emailOrPhone;
    const passwordControl = this.form.formGroup.controls.password;

    if(emailOrPhoneControl.invalid || passwordControl.invalid) {
      return;
    }

    const emailOrPhone = emailOrPhoneControl.value!;
    const password = emailOrPhoneControl.value!;

    this.loading.set(true)
    this.remote.signIn(emailOrPhone, password).pipe(
      tap(response => {

      }),
      catchError(err => {
        const errorMessage = getHttpErrorMessage(err);
        this.errorMessage.set(errorMessage)
        return throwError(() => err);
      }),
      finalize(() => {
        this.loading.set(false);
      })
    ).subscribe();
  }

  signUp() {}

  passwordVisible = computed(() => {
    const screen = this.service.authenticationScreen();
    return ["sign-up", "sign-in"].includes(screen)
  })

  confirmPasswordVisible = computed(() => {
    const screen = this.service.authenticationScreen();
    return ["sign-up"].includes(screen)
  })

  submitButtonVisible = computed(() => {
    const screen = this.service.authenticationScreen();
    return ["sign-up", "sign-in"].includes(screen)
  })
}
