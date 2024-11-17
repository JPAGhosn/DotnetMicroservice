import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-like-icon',
  standalone: true,
  imports: [],
  templateUrl: './like-icon.component.html',
  styleUrl: './like-icon.component.scss'
})
export class LikeIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
