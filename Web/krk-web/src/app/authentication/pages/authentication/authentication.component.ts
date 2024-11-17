import { Component } from '@angular/core';
import { LayoutComponent } from "../../layouts/layout/layout.component";
import { TitleComponent } from "../../components/title/title.component";
import { TitleTextComponent } from "../../components/title-text/title-text.component";
import { TitlePrimaryComponent } from "../../components/title-primary/title-primary.component";
import { AuthenticationFormComponent } from "./components/authentication-form/authentication-form.component";
import { RedirectsComponent } from "../../components/redirects/redirects.component";
import { AuthenticationService } from './services/authentication.service';
import { AuthenticationForm } from './forms/authentication-form';
import { RemoteService } from '@authentication/remotes';

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
