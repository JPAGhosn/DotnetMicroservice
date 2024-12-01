import {Component} from '@angular/core';
import {LayoutComponent} from "@authentication/layouts";
import {
  RedirectsComponent,
  TitleComponent,
  TitlePrimaryComponent,
  TitleTextComponent
} from "@authentication/components";
import {AuthenticationFormComponent, AuthenticationService} from "@authentication/pages";
import {AuthenticationForm} from './forms/authentication-form';
import {RemoteService} from '@authentication/remotes';

@Component({
  selector: 'krk-authentication',
  standalone: true,
  imports: [LayoutComponent, TitleComponent, TitleTextComponent, TitlePrimaryComponent, AuthenticationFormComponent, RedirectsComponent],
  templateUrl: './authentication.component.html',
  styleUrl: './authentication.component.scss',
  providers: [
    AuthenticationForm,
    AuthenticationService,
    RemoteService
  ]
})
export class AuthenticationComponent {

}
