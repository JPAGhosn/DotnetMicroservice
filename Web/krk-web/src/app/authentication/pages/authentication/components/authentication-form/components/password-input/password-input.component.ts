import {Component, computed, effect, ElementRef, inject, ViewChild} from '@angular/core';
import { AuthenticationService } from '@authentication/pages/authentication/services/authentication.service';
import { InputComponent } from '@shared/components';
import {inputAnimation} from '@authentication/animations/inputAnimation';
import {ReactiveFormsModule} from '@angular/forms';

@Component({
  selector: 'krk-password-input',
  standalone: true,
  imports: [InputComponent, ReactiveFormsModule],
  templateUrl: './password-input.component.html',
  styleUrl: './password-input.component.scss',
  animations: [
    inputAnimation
  ]
})
export class PasswordInputComponent {
  service = inject(AuthenticationService)
  form = this.service.form;
  errorsMap = {
    required: "Password is required",
  };
}
