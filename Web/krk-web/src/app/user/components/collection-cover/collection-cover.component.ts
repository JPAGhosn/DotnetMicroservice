import {Component, Input} from '@angular/core';
import {ImageComponent} from '@shared/components/image/image.component';

@Component({
  selector: 'krk-collection-cover',
  standalone: true,
  imports: [
    ImageComponent
  ],
  templateUrl: './collection-cover.component.html',
  styleUrl: './collection-cover.component.scss'
})
export class CollectionCoverComponent {
  @Input({required: false}) coverPath1?: string;
  @Input({required: false}) coverPath2?: string;
  @Input({required: false}) coverPath3?: string;
}
