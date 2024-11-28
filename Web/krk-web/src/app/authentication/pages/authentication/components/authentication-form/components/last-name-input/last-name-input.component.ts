import {Component, inject} from '@angular/core';
import {AuthenticationService} from '@authentication/pages';
import {InputComponent} from '@shared/components';
import {ReactiveFormsModule} from '@angular/forms';
import {inputAnimation} from '@authentication/animations/inputAnimation';

@Component({
  selector: 'krk-last-name-input',
  standalone: true,
  imports: [
    InputComponent,
    ReactiveFormsModule
  ],
  templateUrl: './last-name-input.component.html',
  styleUrl: './last-name-input.component.scss',
  animations: [
    inputAnimation
  ]
})
export class LastNameInputComponent {
  service = inject(AuthenticationService)
  form = this.service.form;
  errorsMap = {
    required: "Lastname is required",
  };
}
