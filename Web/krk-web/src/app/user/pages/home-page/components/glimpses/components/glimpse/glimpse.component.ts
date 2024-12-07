import {Component, Input} from '@angular/core';
import {GlimpseModel} from '../../../../models/glimpse.model';
import {MediaInformationComponent} from '../../../../../../components/media-information/media-information.component';
import {ImageComponent} from '@shared/components/image/image.component';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'krk-glimpse',
  standalone: true,
  imports: [
    MediaInformationComponent,
    ImageComponent,
    NgOptimizedImage
  ],
  templateUrl: './glimpse.component.html',
  styleUrl: './glimpse.component.scss'
})
export class GlimpseComponent {
  @Input({required: true}) glimpse!: GlimpseModel;
}
