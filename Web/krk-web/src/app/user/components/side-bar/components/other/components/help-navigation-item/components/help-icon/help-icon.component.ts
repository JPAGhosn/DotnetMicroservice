import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-help-icon',
  standalone: true,
  imports: [],
  templateUrl: './help-icon.component.html',
  styleUrl: './help-icon.component.scss'
})
export class HelpIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
