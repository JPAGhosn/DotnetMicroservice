import {Component, input} from '@angular/core';
import {MatRipple} from '@angular/material/core';

@Component({
  selector: 'krk-small-button',
  standalone: true,
  imports: [
    MatRipple
  ],
  templateUrl: './small-button.component.html',
  styleUrl: './small-button.component.scss'
})
export class SmallButtonComponent {
  type = input("submit" as "submit" | "cancel");
}
