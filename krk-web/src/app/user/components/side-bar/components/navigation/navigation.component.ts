import {Component, inject} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {NavigationItemComponent} from '../navigation-item/navigation-item.component';
import {HomeIconComponent} from './components/home-navigation-item/components/home-icon/home-icon.component';
import {
  DiscoverIconComponent
} from './components/discover-navigation-item/components/discover-icon/discover-icon.component';
import {
  ConnectIconComponent
} from './components/connect-navigation-item/components/connect-icon/connect-icon.component';
import {
  MySpaceIconComponent
} from './components/my-space-navigation-item/components/my-space-icon/my-space-icon.component';
import {ActivatedRoute} from '@angular/router';
import {HomeNavigationItemComponent} from './components/home-navigation-item/home-navigation-item.component';
import {
  DiscoverNavigationItemComponent
} from './components/discover-navigation-item/discover-navigation-item.component';
import {ConnectNavigationItemComponent} from './components/connect-navigation-item/connect-navigation-item.component';
import {MySpaceNavigationItemComponent} from './components/my-space-navigation-item/my-space-navigation-item.component';

@Component({
  selector: 'krk-navigation',
  standalone: true,
  imports: [
    NgOptimizedImage,
    NavigationItemComponent,
    HomeIconComponent,
    DiscoverIconComponent,
    ConnectIconComponent,
    MySpaceIconComponent,
    HomeNavigationItemComponent,
    DiscoverNavigationItemComponent,
    ConnectNavigationItemComponent,
    MySpaceNavigationItemComponent
  ],
  templateUrl: './navigation.component.html',
  styleUrl: './navigation.component.scss'
})
export class NavigationComponent {
  route = inject(ActivatedRoute);
}
