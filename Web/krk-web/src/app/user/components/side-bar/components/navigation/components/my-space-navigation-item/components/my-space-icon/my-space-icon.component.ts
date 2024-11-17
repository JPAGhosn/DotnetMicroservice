import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-my-space-icon',
  standalone: true,
  imports: [],
  templateUrl: './my-space-icon.component.html',
  styleUrl: './my-space-icon.component.scss'
})
export class MySpaceIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
