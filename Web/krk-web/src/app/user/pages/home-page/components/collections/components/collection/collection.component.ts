import {Component, Input} from '@angular/core';
import {CollectionModel} from '../../../../models/collection.model';
import {ImageComponent} from '@shared/components/image/image.component';
import {MediaInformationComponent} from '../../../media-information/media-information.component';

@Component({
  selector: 'krk-collection',
  standalone: true,
  imports: [
    ImageComponent,
    MediaInformationComponent
  ],
  templateUrl: './collection.component.html',
  styleUrl: './collection.component.scss'
})
export class CollectionComponent {
  @Input({required: true}) collection!: CollectionModel;
}
