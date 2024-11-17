import { Component } from '@angular/core';
import { RedirectComponent, RedirectNavigationTextComponent, RedirectSimpleTextComponent } from '@shared/components';

@Component({
  selector: 'krk-create-account-redirect',
  standalone: true,
  imports: [RedirectComponent, RedirectSimpleTextComponent, RedirectNavigationTextComponent],
  templateUrl: './create-account-redirect.component.html',
  styleUrl: './create-account-redirect.component.scss'
})
export class CreateAccountRedirectComponent {

}
