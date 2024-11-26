import {Component, effect, HostBinding, HostListener, Input, signal} from '@angular/core';

@Component({
  selector: 'krk-navbar-button',
  standalone: true,
  imports: [],
  templateUrl: './navbar-button.component.html',
  styleUrl: './navbar-button.component.scss'
})
export class NavbarButtonComponent {

  down = signal(false)
  @HostBinding("class.down") _down = false;

  @HostBinding("class.with-interaction")
  @Input("show-interaction")
  public showInteraction: boolean = true;

  constructor() {
    effect(() => {
      this._down = this.down();
    });
  }

  @HostListener("mousedown")
  onMouseDown() {
    if (!this.showInteraction) return;
    console.log("down")
    this.down.set(true)
  }

  @HostListener("mouseup")
  onMouseUp() {
    if (!this.showInteraction) return;

    this.down.set(false)
  }
}
