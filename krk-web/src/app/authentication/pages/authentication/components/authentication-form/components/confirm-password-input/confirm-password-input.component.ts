import { Component } from '@angular/core';
import { InputComponent } from '@shared/components';

@Component({
  selector: 'krk-confirm-password-input',
  standalone: true,
  imports: [InputComponent],
  templateUrl: './confirm-password-input.component.html',
  styleUrl: './confirm-password-input.component.scss'
})
export class ConfirmPasswordInputComponent {

}
