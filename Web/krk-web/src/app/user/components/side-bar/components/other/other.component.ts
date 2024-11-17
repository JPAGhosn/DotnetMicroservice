import {Component} from '@angular/core';
import {
  SettingsNavigationItemComponent
} from './components/settings-navigation-item/settings-navigation-item.component';
import {HelpNavigationItemComponent} from './components/help-navigation-item/help-navigation-item.component';
import {
  FeedbackNavigationItemComponent
} from './components/feedback-navigation-item/feedback-navigation-item.component';

@Component({
  selector: 'krk-other',
  standalone: true,
  imports: [
    SettingsNavigationItemComponent,
    HelpNavigationItemComponent,
    FeedbackNavigationItemComponent
  ],
  templateUrl: './other.component.html',
  styleUrl: './other.component.scss'
})
export class OtherComponent {

}
