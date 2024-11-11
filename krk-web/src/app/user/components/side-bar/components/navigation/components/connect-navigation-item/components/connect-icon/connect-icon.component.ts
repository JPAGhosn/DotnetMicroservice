import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-connect-icon',
  standalone: true,
  imports: [],
  templateUrl: './connect-icon.component.html',
  styleUrl: './connect-icon.component.scss'
})
export class ConnectIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
