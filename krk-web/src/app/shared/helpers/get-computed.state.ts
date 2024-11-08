import {computed, signal, Signal} from '@angular/core';

export function getComputedState(focusedSignal: Signal<boolean>, valueSignal: Signal<string>, errorSignal: Signal<string> = signal("")) {
  return computed(() => {
    const focused = focusedSignal();
    const value = valueSignal();
    const error = errorSignal();

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
      return "filled-blurred-normal"
    }
    else if(!focused && value && error) {
      return "filled-blurred-error"
    }


    else if(!focused && !value && !error) {
      return "empty-blurred-normal"
    }
    else if(!focused && !value && error) {
      return "empty-blurred-error"
    }


    return focused ? "filled-focused-normal" : "filled-blurred-normal";
  })
}
