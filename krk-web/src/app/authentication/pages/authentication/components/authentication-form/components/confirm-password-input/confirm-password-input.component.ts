import {Component, inject} from '@angular/core';
import { InputComponent } from '@shared/components';
import {ReactiveFormsModule} from '@angular/forms';
import {AuthenticationService} from '@authentication/pages';

@Component({
  selector: 'krk-confirm-password-input',
  standalone: true,
  imports: [InputComponent, ReactiveFormsModule],
  templateUrl: './confirm-password-input.component.html',
  styleUrl: './confirm-password-input.component.scss'
})
export class ConfirmPasswordInputComponent {
  service = inject(AuthenticationService)
  form = this.service.form;
}
