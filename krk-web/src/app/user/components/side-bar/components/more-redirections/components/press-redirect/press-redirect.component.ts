import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-press-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './press-redirect.component.html',
  styleUrl: './press-redirect.component.scss'
})
export class PressRedirectComponent {

}
