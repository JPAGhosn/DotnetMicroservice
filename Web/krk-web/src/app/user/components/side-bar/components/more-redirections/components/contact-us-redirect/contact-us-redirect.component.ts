import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-contact-us-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './contact-us-redirect.component.html',
  styleUrl: './contact-us-redirect.component.scss'
})
export class ContactUsRedirectComponent {

}
