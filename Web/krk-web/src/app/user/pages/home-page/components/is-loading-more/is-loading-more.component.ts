import {Component} from '@angular/core';
import {MatProgressSpinner} from '@angular/material/progress-spinner';

@Component({
  selector: 'krk-is-loading-more',
  standalone: true,
  imports: [
    MatProgressSpinner
  ],
  templateUrl: './is-loading-more.component.html',
  styleUrl: './is-loading-more.component.scss'
})
export class IsLoadingMoreComponent {

}
