import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-settings-icon',
  standalone: true,
  imports: [],
  templateUrl: './settings-icon.component.html',
  styleUrl: './settings-icon.component.scss'
})
export class SettingsIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;
}
