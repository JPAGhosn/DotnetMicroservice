import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-beta-access-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './beta-access-redirect.component.html',
  styleUrl: './beta-access-redirect.component.scss'
})
export class BetaAccessRedirectComponent {

}
