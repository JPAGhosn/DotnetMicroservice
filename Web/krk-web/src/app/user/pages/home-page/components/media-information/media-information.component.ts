import {Component, Input} from '@angular/core';
import {AvatarComponent} from '../../../../components/avatar/avatar.component';
import {MediaModel} from '../../models/media.model';
import {DatePipe} from '@angular/common';

@Component({
  selector: 'krk-media-information',
  standalone: true,
  imports: [
    AvatarComponent,
    DatePipe
  ],
  templateUrl: './media-information.component.html',
  styleUrl: './media-information.component.scss'
})
export class MediaInformationComponent {
  @Input({required: true}) media!: MediaModel;
}
