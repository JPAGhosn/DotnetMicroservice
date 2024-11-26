import {Component, effect, HostBinding, HostListener, signal} from '@angular/core';

@Component({
  selector: 'krk-icon-button',
  standalone: true,
  imports: [],
  templateUrl: './icon-button.component.html',
  styleUrl: './icon-button.component.scss'
})
export class IconButtonComponent {

  isDown = signal(false);

  @HostBinding("class.down")
  _isDown = false;

  constructor() {
    effect(() => {
      this._isDown = this.isDown();
    });
  }

  @HostListener("mousedown", ['$event'])
  onDown(event: MouseEvent) {
    console.log(".")
    this.isDown.set(true)
  }

  @HostListener("mouseup", ['$event'])
  onUp(event: MouseEvent) {
    console.log("...")
    this.isDown.set(false)
  }
}
