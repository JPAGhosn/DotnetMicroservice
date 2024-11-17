import {Component, Input} from '@angular/core';
import {MatButton} from '@angular/material/button';

@Component({
  selector: 'krk-button',
  standalone: true,
  imports: [
    MatButton
  ],
  templateUrl: './button.component.html',
  styleUrl: './button.component.scss'
})
export class ButtonComponent {
  @Input() type = 'text';
}
