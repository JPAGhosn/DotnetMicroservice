import {Component, Input} from '@angular/core';

@Component({
  selector: 'krk-titled-container',
  standalone: true,
  imports: [],
  templateUrl: './titled-container.component.html',
  styleUrl: './titled-container.component.scss'
})
export class TitledContainerComponent {
  @Input({required: true}) title!: string;
}
