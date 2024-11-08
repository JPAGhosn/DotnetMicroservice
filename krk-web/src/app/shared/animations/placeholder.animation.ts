import {animate, state, style, transition, trigger} from '@angular/animations';

export function placeholderAnimation (props: {
  focused: {
    color: string,
    fontSize: string,
    top: string
  },
  blurred: {
    color: string,
    fontSize: string,
    top: string
  },
  error: {
    color: string
  }
}) {
  return trigger("placeholderAnimation", [
    state("empty-blurred-normal", style({
      fontSize: props.blurred.fontSize,
      top: props.blurred.top,
      color: props.blurred.color
    })),

    state("empty-blurred-error", style({
      fontSize: props.blurred.fontSize,
      top: props.blurred.top,
      color: props.error.color
    })),

    state("filled-blurred-normal", style({
      fontSize: props.focused.fontSize,
      top: props.focused.top,
      color: props.blurred.color
    })),

    state("filled-blurred-error", style({
      fontSize: props.focused.fontSize,
      top: props.focused.top,
      color: props.error.color
    })),


    state("filled-focused-normal", style({
      fontSize: props.focused.fontSize,
      top: props.focused.top,
      color: props.focused.color
    })),

    state("filled-focused-error", style({
      fontSize: props.focused.fontSize,
      top: props.focused.top,
      color: props.error.color
    })),

    state("empty-focused-normal", style({
      fontSize: props.focused.fontSize,
      top: props.focused.top,
      color: props.focused.color
    })),

    state("empty-focused-error", style({
      fontSize: props.focused.fontSize,
      top: props.focused.top,
      color: props.error.color
    })),

    transition('* <=> *', [animate('200ms ease-out')]),
  ])
}
