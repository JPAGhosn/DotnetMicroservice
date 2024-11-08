import {Component, computed, signal} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {placeholderAnimation} from '@shared/animations/placeholder.animation';
import {FormControl} from '@angular/forms';
import {getComputedState} from '@shared/helpers/get-computed.state';

@Component({
  selector: 'krk-search-bar',
  standalone: true,
  imports: [
    NgOptimizedImage
  ],
  templateUrl: './search-bar.component.html',
  styleUrl: './search-bar.component.scss',
  animations: [
    placeholderAnimation({
      focused: {
        fontSize: "10px",
        top: "-8px",
        color: "var(--primary)"
      },
      blurred: {
        fontSize: "*",
        top: "*",
        color: "var(--placeholder)"
      },
      error: {
        color: "var(--error)"
      }
    }),
  ]
})
export class SearchBarComponent {
  control = new FormControl("");
  loading = signal(false);

  focused = signal(false);
  value = signal("");

  placeholderAnimationState = getComputedState(this.focused, this.value);

  onInputFocus() {
    this.focused.set(true);
  }

  onInputBlur() {
    this.focused.set(false);
  }

  onInputChange(value: string) {
    this.value.set(value);
  }

  searchIconPath = computed(() => {
    const focused = this.focused();
    if(focused) {
      return "/icons/search-focused.svg";
    }
    else {
      return "/icons/search.svg";
    }
  })
}
