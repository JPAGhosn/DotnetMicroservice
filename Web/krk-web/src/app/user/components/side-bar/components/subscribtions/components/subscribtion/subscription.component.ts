import {Component, Input} from '@angular/core';
import {SubscriptionModel} from '../../models/subscription.model';
import {AvatarComponent} from '../../../../../avatar/avatar.component';

@Component({
  selector: 'krk-subscribtion',
  standalone: true,
  imports: [
    AvatarComponent
  ],
  templateUrl: './subscription.component.html',
  styleUrl: './subscription.component.scss'
})
export class SubscriptionComponent {
  @Input({required: true}) profile!: SubscriptionModel;

  get firstName() {
    return this.profile.firstName;
  }

  get lastName() {
    return this.profile.lastName;
  }

  get userName() {
    return this.profile.userName;
  }

  get profilePicture() {
    return this.profile.profilePicture;
  }
}
