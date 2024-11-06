import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {CredentialsService} from '@shared/services/credentials.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
  providers: [
  ]
})
export class AppComponent {
  title = 'krk-web';
}
