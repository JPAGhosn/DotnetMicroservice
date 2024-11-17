import {Component} from '@angular/core';
import {RouterOutlet} from '@angular/router';
import {LoaderService} from '@shared/services/loader.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
  providers: [
    LoaderService
  ]
})
export class AppComponent {
  title = 'krk-web';
}
