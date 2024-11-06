import {animate, style, transition, trigger} from '@angular/animations';

export const inputAnimation =     trigger('inputAnimation', [
  transition(':enter', [
    style({ height: 0, opacity: 0 }),
    animate('300ms ease-out', style({ height: '*', opacity: 1 })),
  ]),
  // Exit animation
  transition(':leave', [
    animate('300ms ease-in', style({ height: 0, opacity: 0 })),
  ]),
]);
