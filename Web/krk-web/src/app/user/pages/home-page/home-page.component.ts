import {Component, inject, OnDestroy, OnInit} from '@angular/core';
import {HomeService} from './services/home.service';
import {RecipesRemote} from './remotes/recipes.remote';
import {RecipeComponent} from './components/recipe/recipe.component';
import {RecipesStore} from '../../stores/recipes.store';
import {TagsListComponent} from './components/tags-list/tags-list.component';
import {TagsRemote} from './remotes/tags.remote';
import {ActivatedRoute, Router} from '@angular/router';
import {Subscription} from 'rxjs';
import {GuidHelper} from '@shared/helpers/guid.helper';

@Component({
  selector: 'krk-home-page',
  standalone: true,
  imports: [
    RecipeComponent,
    TagsListComponent,
  ],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss',
  providers: [
    HomeService,
    RecipesRemote,
    TagsRemote,
    GuidHelper,
  ],
})
export class HomePageComponent implements OnInit, OnDestroy {
  homeService = inject(HomeService);
  recipesStore = inject(RecipesStore);
  route = inject(ActivatedRoute);
  guidHelper = inject(GuidHelper);
  router = inject(Router);

  subscriptions = new Subscription();

  ngOnInit() {
    this.listenToQueryParamChange();
  }

  listenToQueryParamChange() {
    // On tagId change, fetch the home page again
    const sub = this.route.queryParams.subscribe(params => {

      // If the tagId is not guid send empty
      const tagIdFromParams = params['tagId'];
      if (this.guidHelper.isGuid(tagIdFromParams)) {
        this.homeService.filterTagId.set(tagIdFromParams);
      } else {
        this.router.navigate([], {
          relativeTo: this.route, // Keeps the current route
          queryParams: {tagId: ""}, // Sets the new tagId
          queryParamsHandling: 'merge', // Preserves other existing query params
          // Alternatively, use 'preserve' to keep all existing query params and override specified ones
        });
      }

      this.homeService.fetch().subscribe();
    });
    this.subscriptions.add(sub);
  }

  ngOnDestroy() {
    this.subscriptions.unsubscribe();
  }
}
