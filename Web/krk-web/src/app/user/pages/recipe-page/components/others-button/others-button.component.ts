import {Component} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {IconButtonComponent} from '../icon-button/icon-button.component';

@Component({
  selector: 'krk-others-button',
  standalone: true,
  imports: [
    NgOptimizedImage,
    IconButtonComponent
  ],
  templateUrl: './others-button.component.html',
  styleUrl: './others-button.component.scss'
})
export class OthersButtonComponent {

}
