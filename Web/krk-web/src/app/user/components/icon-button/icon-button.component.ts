import {Component, signal} from '@angular/core';

@Component({
  selector: 'krk-icon-button',
  standalone: true,
  imports: [],
  templateUrl: './icon-button.component.html',
  styleUrl: './icon-button.component.scss'
})
export class IconButtonComponent {

  down = signal(false);

  onDown() {
    this.down.set(true)
  }

  onUp() {
    this.down.set(false)
  }
}
