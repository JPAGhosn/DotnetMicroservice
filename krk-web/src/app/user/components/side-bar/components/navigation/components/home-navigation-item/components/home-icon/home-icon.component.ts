import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-home-icon',
  standalone: true,
  imports: [],
  templateUrl: './home-icon.component.html',
  styleUrl: './home-icon.component.scss'
})
export class HomeIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
