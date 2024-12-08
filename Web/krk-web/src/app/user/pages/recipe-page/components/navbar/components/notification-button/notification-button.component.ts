import {Component} from '@angular/core';
import {NavbarButtonComponent} from '../navbar-button/navbar-button.component';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'krk-notification-button',
  standalone: true,
  imports: [
    NavbarButtonComponent,
    NgOptimizedImage
  ],
  templateUrl: './notification-button.component.html',
  styleUrl: './notification-button.component.scss'
})
export class NotificationButtonComponent {

}
