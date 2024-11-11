import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-feedback-icon',
  standalone: true,
  imports: [],
  templateUrl: './feedback-icon.component.html',
  styleUrl: './feedback-icon.component.scss'
})
export class FeedbackIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
