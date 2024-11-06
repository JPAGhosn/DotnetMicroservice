import { Component } from '@angular/core';
import {MatProgressSpinner, MatProgressSpinnerModule} from '@angular/material/progress-spinner';

@Component({
  selector: 'krk-loader',
  standalone: true,
  imports: [MatProgressSpinnerModule],
  templateUrl: './loader.component.html',
  styleUrl: './loader.component.scss'
})
export class LoaderComponent {

}
