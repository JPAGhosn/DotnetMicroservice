import {NgClass} from '@angular/common';
import {Component, computed, ElementRef, HostListener, signal, ViewChild} from '@angular/core';

@Component({
  selector: 'krk-icon-submit-button',
  standalone: true,
  imports: [NgClass],
  templateUrl: './icon-submit-button.component.html',
  styleUrl: './icon-submit-button.component.scss'
})
export class IconSubmitButtonComponent {
  @ViewChild("button") button!: ElementRef;

  state = signal<"none" | "hover" | "down">("none")

  classValue = computed(() => {
    const state = this.state()
    return {
      hover: state === 'hover',
      down: state === 'down'
    }
  })

  onMouseEnterButton(event: Event) {
    this.state.set("hover");
  }

  onMouseLeaveButton(event: Event) {
    this.state.set("none");
  }

  onMouseDownButton(event: Event) {
    this.state.set("down");
  }

  onMouseUpButton(event: Event) {
    this.state.set("none");
    this.button.nativeElement.blur();
  }

  @HostListener("click", ["$event"])
  onClick(event: Event) {
    event.stopImmediatePropagation();
  }
}
