import {
  Component,
  ElementRef,
  EventEmitter,
  forwardRef,
  HostListener,
  Input,
  OnDestroy,
  OnInit,
  Output,
  signal,
  ViewChild
} from '@angular/core';
import {IconSubmitButtonComponent} from "@shared/components/input/components";
import {ControlValueAccessor, FormControl, NG_VALUE_ACCESSOR} from '@angular/forms';
import {Subscription, tap} from 'rxjs';
import {ErrorButtonComponent} from "./components/error-button/error-button.component";
import {LoaderComponent} from './components';
import {disableDebugTools} from '@angular/platform-browser';
import {placeholderAnimation} from '@shared/animations/placeholder.animation';
import {getComputedState} from '@shared/helpers/get-computed.state';

@Component({
  selector: 'krk-input',
  standalone: true,
  imports: [IconSubmitButtonComponent, ErrorButtonComponent, LoaderComponent],
  templateUrl: './input.component.html',
  styleUrl: './input.component.scss',
  animations: [
    placeholderAnimation({
      focused: {
        fontSize: "10px",
        top: "-7px",
        color: "var(--primary)"
      },
      blurred: {
        fontSize: "*",
        top: "16px",
        color: "var(--placeholder)"
      },
      error: {
        color: "var(--error)"
      }
    })
  ],
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => InputComponent),
      multi: true
    }
  ],
})
export class InputComponent implements ControlValueAccessor, OnInit, OnDestroy {

  @ViewChild("input") input!: ElementRef;

  @Input({required: true}) placeholder = "";
  @Input() withSubmitButton = false;
  @Input() control?: FormControl<string | null>;
  @Input() errorsMap: { [key: string]: string } = {};
  @Input() loading = signal(false);
  @Input() type = "text";
  @Input() inputId = "";

  isDisabled: boolean = false;

  error = signal("")

  @Output() onSubmit = new EventEmitter<any>();

  focused = signal(false);
  touched = signal(false);
  value = signal("");
  subs$ = new Subscription();
  placeholderAnimationState = getComputedState(this.focused, this.value, this.error);
  protected readonly disableDebugTools = disableDebugTools;

  constructor() {
  }

  // from inner to outer
  public onChange: (value: string) => void = () => {
  };

  public onTouched: () => void = () => {
  };

  ngOnInit(): void {
    this.registerErrorSignal();
  }

  registerErrorSignal() {
    if (this.control) {
      const sub = this.control.statusChanges.pipe(
        tap(status => {
          const errors = this.control?.errors;

          if (!errors) {
            this.error.set("");
            return;
          }

          const key = Object.keys(errors)[0];

          if (!Object.keys(this.errorsMap).includes(key)) {
            this.error.set("");
            return;
          }

          if (this.control?.touched) {
            this.error.set(this.errorsMap[key]!);
          }
        })
      ).subscribe();

      this.subs$.add(sub);
    }
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

  @HostListener("click")
  onClick() {
    this.input.nativeElement.focus();
  }

  onInputFocus() {
    this.touched.set(true);
    this.onTouched();
    this.focused.set(true);
  }

  onInputBlur() {
    this.focused.set(false);
  }

  onInputChange(value: string) {
    this.value.set(value);
    this.onChange(this.value());
    this.touched.set(true);
    this.onTouched();
  }

  setDisabledState(isDisabled: boolean) {
    this.isDisabled = isDisabled;
  }

  ngOnDestroy(): void {
    this.subs$.unsubscribe();
  }
}
