import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, computed, ElementRef, EventEmitter, forwardRef, HostListener, Input, OnDestroy, OnInit, Output, Signal, signal, ViewChild } from '@angular/core';
import { SubmitButtonComponent } from "./components/submit-button/submit-button.component";
import { ControlValueAccessor, FormControl, NG_VALUE_ACCESSOR } from '@angular/forms';
import { toSignal } from '@angular/core/rxjs-interop';
import { map, Subscription, tap } from 'rxjs';
import { ErrorButtonComponent } from "./components/error-button/error-button.component";
import { LoaderComponent } from './components';
import {disableDebugTools} from '@angular/platform-browser';

@Component({
  selector: 'krk-input',
  standalone: true,
  imports: [SubmitButtonComponent, ErrorButtonComponent, LoaderComponent],
  templateUrl: './input.component.html',
  styleUrl: './input.component.scss',
  animations: [
    trigger("placeholderAnimation", [
      state("empry-blured-normal", style({
        fontSize: "*",
        top: "13px",
        color: "var(--placeholder)"
      })),
      state("empry-blured-error", style({
        fontSize: "*",
        top: "13px",
        color: "var(--error)"
      })),

      state("filled-blured-normal", style({
        fontSize: "10px",
        top: "-7px",
        color: "var(--placeholder)"
      })),
      state("filled-blured-error", style({
        fontSize: "10px",
        top: "-7px",
        color: "var(--error)"
      })),


      state("filled-focused-normal", style({
        fontSize: "10px",
        top: "-7px",
        color: "var(--primary)"
      })),
      state("filled-focused-error", style({
        fontSize: "10px",
        top: "-7px",
        color: "var(--error)"
      })),

      state("empty-focused-normal", style({
        fontSize: "10px",
        top: "-7px",
        color: "var(--primary)"
      })),
      state("empty-focused-error", style({
        fontSize: "10px",
        top: "-7px",
        color: "var(--error)"
      })),

      transition('* <=> *', [animate('200ms ease-out')]),
    ])
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

  @Input({ required: true }) placeholder = "";
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

  // from inner to outer
  public onChange: (value: string) => void = () => {};
  public onTouched: () => void = () => {};

  subs$ = new Subscription();

  placeholderAnimationState = computed(() => {
    const focused = this.focused();
    const value = this.value();
    const error = this.error();

    if(focused && value && !error) {
      return "filled-focused-normal"
    }
    else if(focused && value && error) {
      return "filled-focused-error"
    }

    else if(focused && !value && !error) {
      return "empty-focused-normal"
    }
    else if(focused && !value && error) {
      return "empty-focused-error"
    }


    else if(!focused && value && !error) {
      return "filled-blured-normal"
    }
    else if(!focused && value && error) {
      return "filled-blured-error"
    }


    else if(!focused && !value && !error) {
      return "empry-blured-normal"
    }
    else if(!focused && !value && error) {
      return "empry-blured-error"
    }


    return focused ? "filled-focused-normal" : "filled-blured-normal";
  })

  constructor() {
  }

  ngOnInit(): void {
    this.registerErrorSignal();
  }

  registerErrorSignal() {
    if(this.control) {
      const sub = this.control.statusChanges.pipe(
        tap(status => {
          const errors = this.control?.errors;

          if(!errors) {
            this.error.set("");
            return;
          }

          const key = Object.keys(errors)[0];

          if(!Object.keys(this.errorsMap).includes(key)) {
            this.error.set("");
            return;
          }

          if(this.control?.touched) {
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

  protected readonly disableDebugTools = disableDebugTools;
}
