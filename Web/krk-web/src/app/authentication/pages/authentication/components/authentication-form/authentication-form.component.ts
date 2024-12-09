import {Component, computed, effect, ElementRef, inject, ViewChild} from '@angular/core';
import {ConfirmPasswordInputComponent, EmailInputComponent, PasswordInputComponent} from './components';
import {AuthenticationForm} from '../../forms/authentication-form';
import {ReactiveFormsModule} from '@angular/forms';
import {AuthenticationService} from '@authentication/pages';
import {
  AuthenticationSubmitButtonComponent
} from '@authentication/components/submit-button/authentication-submit-button.component';
import {RemoteService} from '@authentication/remotes';
import {Router} from '@angular/router';
import {
  FirstNameInputComponent
} from '@authentication/pages/authentication/components/authentication-form/components/first-name-input/first-name-input.component';
import {
  LastNameInputComponent
} from '@authentication/pages/authentication/components/authentication-form/components/last-name-input/last-name-input.component';
import {
  SignInService
} from '@authentication/pages/authentication/components/authentication-form/services/sign-in.service';
import {
  SignUpService
} from '@authentication/pages/authentication/components/authentication-form/services/sign-up.service';
import {
  CheckEmailExistService
} from '@authentication/pages/authentication/components/authentication-form/services/check-email-exist.service';

@Component({
  selector: 'krk-authentication-form',
  standalone: true,
  imports: [EmailInputComponent, PasswordInputComponent, ConfirmPasswordInputComponent, ReactiveFormsModule, AuthenticationSubmitButtonComponent, FirstNameInputComponent, LastNameInputComponent],
  templateUrl: './authentication-form.component.html',
  styleUrl: './authentication-form.component.scss',
  providers: [
    SignInService,
    SignUpService,
    CheckEmailExistService
  ]
})
export class AuthenticationFormComponent {
  form = inject(AuthenticationForm)
  remote = inject(RemoteService)
  router = inject(Router);
  signInService = inject(SignInService);
  signUpService = inject(SignUpService);
  checkEmailExists = inject(CheckEmailExistService);
  authenticationService = inject(AuthenticationService)

  @ViewChild("password") passwordElementRef!: ElementRef;
  @ViewChild("confirmPassword") confirmPasswordElementRef!: ElementRef;

  passwordVisible = computed(() => {
    const screen = this.authenticationService.authenticationScreen();
    return ["sign-up", "sign-in"].includes(screen)
  })
  confirmPasswordVisible = computed(() => {
    const screen = this.authenticationService.authenticationScreen();
    return ["sign-up"].includes(screen)
  })
  userInformationVisible = computed(() => {
    const screen = this.authenticationService.authenticationScreen();
    return ["sign-up"].includes(screen)
  })
  submitButtonVisible = computed(() => {
    const screen = this.authenticationService.authenticationScreen();
    return ["sign-up", "sign-in"].includes(screen)
  })

  constructor() {
    effect(() => {

      const screen = this.authenticationService.authenticationScreen();

      const emailDisabled = ["sign-up", "sign-in"].includes(screen);

      if (emailDisabled) {
        this.form.formGroup.controls.emailOrPhone.disable();
      } else {
        this.form.formGroup.controls.emailOrPhone.enable();
      }
    });
  }

  onSubmit() {
    const screen = this.authenticationService.authenticationScreen();
    switch (screen) {
      case "sign-in":
        console.log("Sign In")
        this.signInService.signIn();
        break;
      case "sign-up":
        this.signUpService.signUp();
        break;
      case "starter":
        this.checkEmailExists.checkEmailExists();
        break;
      default:
        throw "Screen not handled";
    }
  }
}
