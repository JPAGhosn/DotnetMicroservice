import {Component, computed, effect, ElementRef, inject, ViewChild} from '@angular/core';
import { AuthenticationService } from '@authentication/pages/authentication/services/authentication.service';
import { InputComponent } from '@shared/components';
import {inputAnimation} from '@authentication/animations/inputAnimation';

@Component({
  selector: 'krk-password-input',
  standalone: true,
  imports: [InputComponent],
  templateUrl: './password-input.component.html',
  styleUrl: './password-input.component.scss',
  animations: [
    inputAnimation
  ]
})
export class PasswordInputComponent {
}
