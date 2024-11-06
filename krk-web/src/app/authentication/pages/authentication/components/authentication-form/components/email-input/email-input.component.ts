import {Component, inject, Input, signal} from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationForm } from '@authentication/pages/authentication/forms/authentication-form';
import { AuthenticationService } from '@authentication/pages/authentication/services';
import { InputComponent } from '@shared/components';
import {inputAnimation} from '@authentication/animations/inputAnimation';

@Component({
  selector: 'krk-email-input',
  standalone: true,
  imports: [InputComponent, ReactiveFormsModule],
  templateUrl: './email-input.component.html',
  styleUrl: './email-input.component.scss',
  providers: [],
  animations: [
    inputAnimation
  ]
})
export class EmailInputComponent {
  form = inject(AuthenticationForm);

  @Input({ required: true }) loading = signal(false);

  errorsMap: { [key: string]: string } = {
    "required": "Email is required",
    "email": "Email is invalid"
  };
}
