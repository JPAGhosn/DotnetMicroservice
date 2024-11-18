import {Component, inject, OnInit} from '@angular/core';
import {HomeService} from './services/home.service';
import {RecipesRemote} from './remotes/recipes.remote';
import {RecipeComponent} from './components/recipe/recipe.component';
import {GroupContainerComponent} from '@shared/components/group-container/group-container.component';
import {RecipesStore} from '../../stores/recipes.store';

@Component({
  selector: 'krk-home-page',
  standalone: true,
  imports: [
    RecipeComponent,
    GroupContainerComponent
  ],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss',
  providers: [
    HomeService,
    RecipesRemote,
  ],
})
export class HomePageComponent implements OnInit {
  homeService = inject(HomeService);
  recipesStore = inject(RecipesStore);

  ngOnInit() {
    this.homeService.fetch().subscribe();
  }
}
