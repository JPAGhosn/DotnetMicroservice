import { Component } from '@angular/core';
import { RedirectComponent, RedirectNavigationTextComponent, RedirectSimpleTextComponent } from '@shared/components';

@Component({
  selector: 'krk-forgot-password-redirect',
  standalone: true,
  imports: [RedirectComponent, RedirectSimpleTextComponent, RedirectNavigationTextComponent],
  templateUrl: './forgot-password-redirect.component.html',
  styleUrl: './forgot-password-redirect.component.scss'
})
export class ForgotPasswordRedirectComponent {

}
