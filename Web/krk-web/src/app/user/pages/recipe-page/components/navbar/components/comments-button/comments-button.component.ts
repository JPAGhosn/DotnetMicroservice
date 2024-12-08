import {Component} from '@angular/core';
import {NavbarButtonComponent} from '../navbar-button/navbar-button.component';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'krk-comments-button',
  standalone: true,
  imports: [
    NavbarButtonComponent,
    NgOptimizedImage
  ],
  templateUrl: './comments-button.component.html',
  styleUrl: './comments-button.component.scss'
})
export class CommentsButtonComponent {

}
