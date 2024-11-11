import {Component, Input} from '@angular/core';

@Component({
  selector: 'krk-redirect',
  standalone: true,
  imports: [],
  templateUrl: './redirect.component.html',
  styleUrl: './redirect.component.scss'
})
export class RedirectComponent {
  @Input({required: true}) label!: string;
}
