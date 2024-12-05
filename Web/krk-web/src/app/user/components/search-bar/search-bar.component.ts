import {Component, computed, forwardRef, Input, signal} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {placeholderAnimation} from '@shared/animations/placeholder.animation';
import {ControlValueAccessor, NG_VALUE_ACCESSOR} from '@angular/forms';
import {getComputedState} from '@shared/helpers/get-computed.state';

@Component({
  selector: 'krk-search-bar',
  standalone: true,
  imports: [
    NgOptimizedImage
  ],
  templateUrl: './search-bar.component.html',
  styleUrl: './search-bar.component.scss',
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => SearchBarComponent),
      multi: true
    }
  ],
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
export class SearchBarComponent implements ControlValueAccessor {
  @Input() placeholder = "Search for anything"

  loading = signal(false);

  focused = signal(false);
  value = signal("");
  disabled = signal(false);

  placeholderAnimationState = getComputedState(this.focused, this.value);
  searchIconPath = computed(() => {
    const focused = this.focused();
    if (focused) {
      return "/icons/search-focused.svg";
    } else {
      return "/icons/search.svg";
    }
  })

  // from inner to outer
  public onChange: (value: string) => void = () => {
  };
  public onTouched: () => void = () => {
  };

  // inner
  onInputChange(input: string): void {
    this.value.set(input);
    this.onChange(this.value());
  }

  // outer
  writeValue(value: string): void {
    this.value.set(value || '');
  }

  registerOnChange(fn: (value: string) => void): void {
    this.onChange = fn;
  }

  registerOnTouched(fn: () => void): void {
    this.onTouched = fn;
  }

  setDisabledState(isDisabled: boolean): void {
    this.disabled.set(isDisabled);
  }

  onInputFocus() {
    this.focused.set(true);
  }

  onInputBlur() {
    this.focused.set(false);
  }

}
