import { Component } from '@angular/core';
import {NgOptimizedImage} from "@angular/common";

@Component({
  selector: 'krk-notification-button',
  standalone: true,
    imports: [
        NgOptimizedImage
    ],
  templateUrl: './notification-button.component.html',
  styleUrl: './notification-button.component.scss'
})
export class NotificationButtonComponent {

}
