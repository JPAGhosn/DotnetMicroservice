import {Component} from '@angular/core';
import {NavbarButtonComponent} from '../navbar-button/navbar-button.component';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'krk-add-to-collection-button',
  standalone: true,
  imports: [
    NavbarButtonComponent,
    NgOptimizedImage
  ],
  templateUrl: './add-to-collection-button.component.html',
  styleUrl: './add-to-collection-button.component.scss'
})
export class AddToCollectionButtonComponent {

}
