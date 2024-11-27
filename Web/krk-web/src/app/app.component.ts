import {Component} from '@angular/core';
import {RouterOutlet} from '@angular/router';
import {LoaderService} from '@shared/services/loader.service';
import {SnackbarService} from '@shared/services/snackbar.service';
import {SnackbarComponent} from '@shared/components/snackbar/snackbar.component';
import {ModalsComponent} from '@shared/components/modals/modals.component';
import {ModalsService} from '@shared/components/modals/services/modals.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, SnackbarComponent, ModalsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
  providers: [
    LoaderService,
    SnackbarService,
    ModalsService
  ]
})
export class AppComponent {
  title = 'krk-web';
}
