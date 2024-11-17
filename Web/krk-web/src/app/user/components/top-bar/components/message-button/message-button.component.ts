import { Component } from '@angular/core';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'krk-message-button',
  standalone: true,
  imports: [
    NgOptimizedImage
  ],
  templateUrl: './message-button.component.html',
  styleUrl: './message-button.component.scss'
})
export class MessageButtonComponent {

}
