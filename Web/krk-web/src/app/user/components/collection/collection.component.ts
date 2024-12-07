import {Component, Input} from '@angular/core';
import {CollectionModel} from '../../pages/home-page/models/collection.model';
import {ImageComponent} from '@shared/components/image/image.component';
import {MediaInformationComponent} from '../media-information/media-information.component';
import {CollectionCoverComponent} from '../collection-cover/collection-cover.component';

@Component({
  selector: 'krk-collection',
  standalone: true,
  imports: [
    ImageComponent,
    MediaInformationComponent,
    CollectionCoverComponent
  ],
  templateUrl: './collection.component.html',
  styleUrl: './collection.component.scss'
})
export class CollectionComponent {
  @Input({required: true}) collection!: CollectionModel;

}
