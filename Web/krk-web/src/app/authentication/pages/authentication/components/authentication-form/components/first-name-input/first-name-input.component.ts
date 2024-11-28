import {Component, inject} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {InputComponent} from "@shared/components";
import {AuthenticationService} from '@authentication/pages';
import {inputAnimation} from '@authentication/animations/inputAnimation';

@Component({
  selector: 'krk-first-name-input',
  standalone: true,
  imports: [
    FormsModule,
    InputComponent,
    ReactiveFormsModule
  ],
  templateUrl: './first-name-input.component.html',
  styleUrl: './first-name-input.component.scss',
  animations: [
    inputAnimation
  ]
})
export class FirstNameInputComponent {
  service = inject(AuthenticationService)
  form = this.service.form;
  errorsMap = {
    required: "Firstname is required",
  };
}
