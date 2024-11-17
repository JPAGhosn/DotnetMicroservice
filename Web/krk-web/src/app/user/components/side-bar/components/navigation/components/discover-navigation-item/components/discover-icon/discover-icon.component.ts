import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-discover-icon',
  standalone: true,
  imports: [],
  templateUrl: './discover-icon.component.html',
  styleUrl: './discover-icon.component.scss'
})
export class DiscoverIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
