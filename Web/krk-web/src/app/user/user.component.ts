import {Component, inject} from '@angular/core';
import {TopBarComponent} from './components/top-bar/top-bar.component';
import {SideBarComponent} from './components/side-bar/side-bar.component';
import {RouterOutlet} from '@angular/router';
import {SubscriptionsStore} from './stores/subscriptions.store';
import {RecipesStore} from './stores/recipes.store';
import {TagsStore} from './stores/tags.store';
import {GlimpsesStore} from './stores/glimpses.store';
import {CollectionsStore} from './stores/collections.store';
import {RepositoriesStore} from './stores/repositories.store';
import {ResponsiveService} from '@shared/services/responsive.service';
import {BottomNavbarComponent} from './components/bottom-navbar/bottom-navbar.component';

const stores = [
  SubscriptionsStore,
  RecipesStore,
  RepositoriesStore,
  TagsStore,
  GlimpsesStore,
  CollectionsStore
]

@Component({
  selector: 'krk-user',
  standalone: true,
  imports: [
    TopBarComponent,
    SideBarComponent,
    RouterOutlet,
    BottomNavbarComponent,
  ],
  providers: [
    stores,

  ],
  templateUrl: './user.component.html',
  styleUrl: './user.component.scss'
})
export class UserComponent {
  responsiveService = inject(ResponsiveService)
}
