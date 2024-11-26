import {Component} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {NavbarButtonComponent} from '../navbar-button/navbar-button.component';

@Component({
  selector: 'krk-like-dislike-buttons',
  standalone: true,
  imports: [
    NgOptimizedImage,
    NavbarButtonComponent
  ],
  templateUrl: './like-dislike-buttons.component.html',
  styleUrl: './like-dislike-buttons.component.scss'
})
export class LikeDislikeButtonsComponent {

}
