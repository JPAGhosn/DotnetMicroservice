import {Component, Input} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'krk-navigation-item',
  standalone: true,
  imports: [
    NgOptimizedImage
  ],
  templateUrl: './navigation-item.component.html',
  styleUrl: './navigation-item.component.scss'
})
export class NavigationItemComponent {
  @Input({required: true}) label!: string;
}
