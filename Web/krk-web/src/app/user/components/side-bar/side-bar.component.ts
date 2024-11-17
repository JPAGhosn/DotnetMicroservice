import {Component, OnInit} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {MoreRedirectionsComponent} from './components/more-redirections/more-redirections.component';
import {OtherComponent} from './components/other/other.component';
import {SubscriptionsComponent} from './components/subscribtions/subscriptions.component';
import {MySpaceComponent} from './components/my-space/my-space.component';
import {NavigationComponent} from './components/navigation/navigation.component';
import {SpacerComponent} from './components/spacer/spacer.component';
import {CopyrightNoticeComponent} from './components/copyright-notice/copyright-notice.component';

@Component({
  selector: 'krk-side-bar',
  standalone: true,
  imports: [
    NgOptimizedImage,
    MoreRedirectionsComponent,
    OtherComponent,
    SubscriptionsComponent,
    MySpaceComponent,
    NavigationComponent,
    SpacerComponent,
    CopyrightNoticeComponent
  ],
  templateUrl: './side-bar.component.html',
  styleUrl: './side-bar.component.scss',
  providers: []
})
export class SideBarComponent implements OnInit {

  ngOnInit() {
  }
}
