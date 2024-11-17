import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-copyright-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './copyright-redirect.component.html',
  styleUrl: './copyright-redirect.component.scss'
})
export class CopyrightRedirectComponent {

}
