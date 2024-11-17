import { Component } from '@angular/core';
import { ForgotPasswordRedirectComponent } from "./components/forgot-password-redirect/forgot-password-redirect.component";
import { CreateAccountRedirectComponent } from "./components/create-account-redirect/create-account-redirect.component";

@Component({
  selector: 'krk-redirects',
  standalone: true,
  imports: [ForgotPasswordRedirectComponent, CreateAccountRedirectComponent],
  templateUrl: './redirects.component.html',
  styleUrl: './redirects.component.scss'
})
export class RedirectsComponent {

}
