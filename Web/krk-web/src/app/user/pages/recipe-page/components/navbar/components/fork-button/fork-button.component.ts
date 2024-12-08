import {Component} from '@angular/core';
import {DropdownButtonComponent} from '../dropdown-button/dropdown-button.component';

@Component({
  selector: 'krk-fork-button',
  standalone: true,
  imports: [
    DropdownButtonComponent
  ],
  templateUrl: './fork-button.component.html',
  styleUrl: './fork-button.component.scss'
})
export class ForkButtonComponent {

  onSelect(event: any) {

  }
}
