import {Component} from '@angular/core';

@Component({
  selector: 'krk-copyright-notice',
  standalone: true,
  imports: [],
  templateUrl: './copyright-notice.component.html',
  styleUrl: './copyright-notice.component.scss'
})
export class CopyrightNoticeComponent {
  year = new Date().getFullYear();
}
