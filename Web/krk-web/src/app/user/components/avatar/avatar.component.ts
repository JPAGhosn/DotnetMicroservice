import {Component, Input, TemplateRef} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {MatProgressSpinner} from '@angular/material/progress-spinner';
import {ImageComponent} from '@shared/components/image/image.component';

@Component({
  selector: 'krk-avatar',
  standalone: true,
  imports: [
    NgOptimizedImage,
    MatProgressSpinner,
    ImageComponent
  ],
  templateUrl: './avatar.component.html',
  styleUrl: './avatar.component.scss'
})
export class AvatarComponent {
  @Input({required: true}) image?: string;

  @Input() errorTemplate?: TemplateRef<any>;
}
