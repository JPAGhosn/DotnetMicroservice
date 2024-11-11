import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-about-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './about-redirect.component.html',
  styleUrl: './about-redirect.component.scss'
})
export class AboutRedirectComponent {

}
