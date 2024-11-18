import {Component, Input} from '@angular/core';

@Component({
  selector: 'krk-group-container',
  standalone: true,
  imports: [],
  templateUrl: './group-container.component.html',
  styleUrl: './group-container.component.scss'
})
export class GroupContainerComponent {
  @Input() column: number = 4;
}
