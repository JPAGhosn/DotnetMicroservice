import {Component} from '@angular/core';
import {NavbarButtonComponent} from '../navbar-button/navbar-button.component';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'krk-share-button',
  standalone: true,
  imports: [
    NavbarButtonComponent,
    NgOptimizedImage
  ],
  templateUrl: './share-button.component.html',
  styleUrl: './share-button.component.scss'
})
export class ShareButtonComponent {

}
