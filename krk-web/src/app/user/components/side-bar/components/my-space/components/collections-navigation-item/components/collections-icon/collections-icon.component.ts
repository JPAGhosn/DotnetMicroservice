import {Component, Input, Signal} from '@angular/core';

@Component({
  selector: 'krk-collections-icon',
  standalone: true,
  imports: [],
  templateUrl: './collections-icon.component.html',
  styleUrl: './collections-icon.component.scss'
})
export class CollectionsIconComponent {
  @Input({required: true}) selected!: Signal<boolean>;

}
