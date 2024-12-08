import {Component, HostListener, Input, signal} from '@angular/core';

@Component({
  selector: 'krk-navbar-button',
  standalone: true,
  imports: [],
  templateUrl: './navbar-button.component.html',
  styleUrl: './navbar-button.component.scss'
})
export class NavbarButtonComponent {

  down = signal(false)

  @Input("show-interaction")
  public showInteraction: boolean = true;
  protected readonly onkeydown = onkeydown;
  protected readonly onkeyup = onkeyup;

  @HostListener("mousedown")
  onMouseDown() {
    if (!this.showInteraction) return;
    this.down.set(true)
  }

  onMouseUp() {
    if (!this.showInteraction) return;
    this.down.set(false)
  }
}
