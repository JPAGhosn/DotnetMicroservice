import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-piracy-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './piracy-redirect.component.html',
  styleUrl: './piracy-redirect.component.scss'
})
export class PiracyRedirectComponent {

}
