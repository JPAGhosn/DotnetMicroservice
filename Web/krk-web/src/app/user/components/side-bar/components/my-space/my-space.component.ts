import {Component, computed, signal} from '@angular/core';
import {NavigationItemComponent} from '../navigation-item/navigation-item.component';
import {LikeIconComponent} from './components/liked-items-navigation-item/components/like-icon/like-icon.component';
import {TitleComponent} from '../title/title.component';
import {
  SeeLaterIconComponent
} from './components/see-later-navigation-item/components/see-later-icon/see-later-icon.component';
import {
  CollectionsIconComponent
} from './components/collections-navigation-item/components/collections-icon/collections-icon.component';
import {
  LikedItemsNavigationItemComponent
} from './components/liked-items-navigation-item/liked-items-navigation-item.component';
import {
  SeeLaterNavigationItemComponent
} from './components/see-later-navigation-item/see-later-navigation-item.component';
import {
  CollectionsNavigationItemComponent
} from './components/collections-navigation-item/collections-navigation-item.component';

@Component({
  selector: 'krk-my-space',
  standalone: true,
  imports: [
    NavigationItemComponent,
    LikeIconComponent,
    TitleComponent,
    SeeLaterIconComponent,
    CollectionsIconComponent,
    LikedItemsNavigationItemComponent,
    SeeLaterNavigationItemComponent,
    CollectionsNavigationItemComponent
  ],
  templateUrl: './my-space.component.html',
  styleUrl: './my-space.component.scss'
})
export class MySpaceComponent {
  selected = signal("liked-items");

  isSeeLaterSelected = computed(() => {
    return this.selected() === "see-later-page";
  })

  isCollectionsSelected = computed(() => {
    return this.selected() === "collections";
  })
}
