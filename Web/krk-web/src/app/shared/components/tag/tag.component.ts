import {Component, HostBinding, Input} from '@angular/core';

@Component({
  selector: 'krk-tag',
  standalone: true,
  imports: [],
  templateUrl: './tag.component.html',
  styleUrl: './tag.component.scss'
})
export class TagComponent {

  @HostBinding("class.active")
  @Input() active: boolean = true;
}
