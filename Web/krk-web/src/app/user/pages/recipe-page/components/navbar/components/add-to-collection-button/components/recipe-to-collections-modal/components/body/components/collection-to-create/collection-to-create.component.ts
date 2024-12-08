import {Component} from '@angular/core';
import {ImageComponent} from '@shared/components/image/image.component';
import {
  MediaInformationComponent
} from '../../../../../../../../../../../../components/media-information/media-information.component';
import {
  CollectionCoverComponent
} from '../../../../../../../../../../../../components/collection-cover/collection-cover.component';
import {
  MediaInformationEditableComponent
} from './components/media-information-editable/media-information-editable.component';
import {AddButtonComponent} from '../add-button/add-button.component';
import {FormControl, ReactiveFormsModule} from '@angular/forms';

@Component({
  selector: 'krk-collection-to-create',
  standalone: true,
  imports: [
    ImageComponent,
    MediaInformationComponent,
    CollectionCoverComponent,
    MediaInformationEditableComponent,
    AddButtonComponent,
    ReactiveFormsModule
  ],
  templateUrl: './collection-to-create.component.html',
  styleUrl: './collection-to-create.component.scss'
})
export class CollectionToCreateComponent {
  nameControl = new FormControl("");
}
