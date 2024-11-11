import {Component} from '@angular/core';
import {RedirectComponent} from './components/redirect/redirect.component';
import {AboutRedirectComponent} from './components/about-redirect/about-redirect.component';
import {PressRedirectComponent} from './components/press-redirect/press-redirect.component';
import {ContactUsRedirectComponent} from './components/contact-us-redirect/contact-us-redirect.component';
import {CopyrightRedirectComponent} from './components/copyright-redirect/copyright-redirect.component';
import {CreatorsRedirectComponent} from './components/creators-redirect/creators-redirect.component';
import {AdvertisersRedirectComponent} from './components/advertisers-redirect/advertisers-redirect.component';
import {DevelopersRedirectComponent} from './components/developers-redirect/developers-redirect.component';
import {TermsRedirectComponent} from './components/terms-redirect/terms-redirect.component';
import {PrivacyRedirectComponent} from './components/privacy-redirect/privacy-redirect.component';
import {PiracyRedirectComponent} from './components/piracy-redirect/piracy-redirect.component';
import {HowRedirectComponent} from './components/how-redirect/how-redirect.component';
import {BetaAccessRedirectComponent} from './components/beta-access-redirect/beta-access-redirect.component';

@Component({
  selector: 'krk-more-redirections',
  standalone: true,
  imports: [
    RedirectComponent,
    AboutRedirectComponent,
    PressRedirectComponent,
    ContactUsRedirectComponent,
    CopyrightRedirectComponent,
    CreatorsRedirectComponent,
    AdvertisersRedirectComponent,
    DevelopersRedirectComponent,
    TermsRedirectComponent,
    PrivacyRedirectComponent,
    PiracyRedirectComponent,
    HowRedirectComponent,
    BetaAccessRedirectComponent
  ],
  templateUrl: './more-redirections.component.html',
  styleUrl: './more-redirections.component.scss'
})
export class MoreRedirectionsComponent {

}
