import { Component, HostListener, Input, Signal, signal } from '@angular/core';
import { MatTooltip, MatTooltipModule } from '@angular/material/tooltip';

@Component({
  selector: 'krk-error-button',
  standalone: true,
  imports: [MatTooltipModule],
  templateUrl: './error-button.component.html',
  styleUrl: './error-button.component.scss'
})
export class ErrorButtonComponent {
  @Input({ required: true }) error!: Signal<string>;

  @HostListener("click", ["$event"])
  onClick(event: Event) {
    event.preventDefault();
    event.stopImmediatePropagation();
  }
}
