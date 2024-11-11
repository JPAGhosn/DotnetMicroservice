import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-developers-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './developers-redirect.component.html',
  styleUrl: './developers-redirect.component.scss'
})
export class DevelopersRedirectComponent {

}
