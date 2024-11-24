import {Component, computed, inject} from '@angular/core';
import {SnackbarService} from '@shared/services/snackbar.service';
import {NgClass} from '@angular/common';
import {animate, style, transition, trigger} from '@angular/animations';

@Component({
  selector: 'krk-snackbar',
  standalone: true,
  imports: [
    NgClass
  ],
  templateUrl: './snackbar.component.html',
  styleUrl: './snackbar.component.scss',
  animations: [
    trigger('snackbarAnimation', [
      transition(':enter', [
        style({bottom: -100}),
        animate('300ms ease-out', style({bottom: 23})),
      ]),
      // Exit animation
      transition(':leave', [
        style({bottom: 23}),
        animate('200ms ease-in', style({bottom: -100})),
      ]),
    ]),
  ]
})
export class SnackbarComponent {
  snackbarService = inject(SnackbarService);

  snackbarClass = computed(() => {
    const type = this.snackbarService.type();
    return {
      "error": type === "error",
      "success": type === "success",
    };
  })

  onCloseSnackbarClicked() {
    this.snackbarService.hide()
  }
}
