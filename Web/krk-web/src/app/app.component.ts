import {Component} from '@angular/core';
import {RouterOutlet} from '@angular/router';
import {LoaderService} from '@shared/services/loader.service';
import {SnackbarService} from '@shared/services/snackbar.service';
import {SnackbarComponent} from '@shared/components/snackbar/snackbar.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, SnackbarComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
  providers: [
    LoaderService,
    SnackbarService
  ]
})
export class AppComponent {
  title = 'krk-web';
}
