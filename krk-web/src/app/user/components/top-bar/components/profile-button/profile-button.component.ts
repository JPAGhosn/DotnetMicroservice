import {Component} from '@angular/core';
import {AvatarComponent} from '../../../avatar/avatar.component';

@Component({
  selector: 'krk-profile-button',
  standalone: true,
  imports: [
    AvatarComponent
  ],
  templateUrl: './profile-button.component.html',
  styleUrl: './profile-button.component.scss'
})
export class ProfileButtonComponent {

}
