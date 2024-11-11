import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-terms-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './terms-redirect.component.html',
  styleUrl: './terms-redirect.component.scss'
})
export class TermsRedirectComponent {

}
