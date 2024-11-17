import {Component} from '@angular/core';
import {RedirectComponent} from '../redirect/redirect.component';

@Component({
  selector: 'krk-advertisers-redirect',
  standalone: true,
  imports: [
    RedirectComponent
  ],
  templateUrl: './advertisers-redirect.component.html',
  styleUrl: './advertisers-redirect.component.scss'
})
export class AdvertisersRedirectComponent {

}
