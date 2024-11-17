import {Component, computed, inject, signal} from '@angular/core';
import {ButtonComponent} from '@shared/components/button/button.component';
import {AuthenticationService} from '@authentication/pages';

@Component({
  selector: 'krk-submit-button',
  standalone: true,
  imports: [
    ButtonComponent
  ],
  templateUrl: './submit-button.component.html',
  styleUrl: './submit-button.component.scss'
})
export class SubmitButtonComponent {
  service = inject(AuthenticationService);

  text = computed(() => {
    const screen = this.service.authenticationScreen()
    switch (screen) {
      case "sign-in":
        return "Sign In"
      case "sign-up":
        return "Sign Up"
      case "starter":
        return "Continue";
      default:
        throw "Screen not handled";
    }
  });


}
