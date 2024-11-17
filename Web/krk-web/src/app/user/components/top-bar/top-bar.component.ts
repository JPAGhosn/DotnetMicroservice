import { Component } from '@angular/core';
import {NgOptimizedImage} from "@angular/common";
import {SearchBarComponent} from './components/search-bar/search-bar.component';
import {MessageButtonComponent} from './components/message-button/message-button.component';
import {NotificationButtonComponent} from './components/notification-button/notification-button.component';
import {ProfileButtonComponent} from './components/profile-button/profile-button.component';

@Component({
  selector: 'krk-top-bar',
  standalone: true,
  imports: [
    NgOptimizedImage,
    SearchBarComponent,
    MessageButtonComponent,
    NotificationButtonComponent,
    ProfileButtonComponent
  ],
  templateUrl: './top-bar.component.html',
  styleUrl: './top-bar.component.scss'
})
export class TopBarComponent {

}
