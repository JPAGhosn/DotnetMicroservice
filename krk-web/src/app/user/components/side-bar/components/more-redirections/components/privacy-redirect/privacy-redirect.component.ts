import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-privacy-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './privacy-redirect.component.html',
  styleUrl: './privacy-redirect.component.scss'
})
export class PrivacyRedirectComponent {

}
