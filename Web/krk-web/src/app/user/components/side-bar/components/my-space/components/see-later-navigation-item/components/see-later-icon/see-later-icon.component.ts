import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-see-later-icon',
  standalone: true,
  imports: [],
  templateUrl: './see-later-icon.component.html',
  styleUrl: './see-later-icon.component.scss'
})
export class SeeLaterIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;

}
