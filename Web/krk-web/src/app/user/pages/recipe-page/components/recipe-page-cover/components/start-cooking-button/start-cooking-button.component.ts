import {Component} from '@angular/core';
import {IconSubmitButtonComponent} from '@shared/components/input/components';
import {ButtonComponent} from '@shared/components/button/button.component';

@Component({
  selector: 'krk-start-cooking-button',
  standalone: true,
  imports: [
    IconSubmitButtonComponent,
    ButtonComponent
  ],
  templateUrl: './start-cooking-button.component.html',
  styleUrl: './start-cooking-button.component.scss'
})
export class StartCookingButtonComponent {

}
