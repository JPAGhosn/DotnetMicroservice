import {Component, computed, HostListener, inject, OnDestroy, OnInit, signal} from '@angular/core';
import {HomeService} from './services/home.service';
import {RecipesRemote} from './remotes/recipes.remote';
import {TagsListComponent} from './components/tags-list/tags-list.component';
import {TagsRemote} from './remotes/tags.remote';
import {ActivatedRoute, Router} from '@angular/router';
import {Subscription} from 'rxjs';
import {GuidHelper} from '@shared/helpers/guid.helper';
import {GlimpseComponent} from './components/glimpses/components/glimpse/glimpse.component';
import {GlimpsesRemote} from './remotes/glimpses.remote';
import {GlimpsesComponent} from './components/glimpses/glimpses.component';
import {RecipesStore} from '../../stores/recipes.store';
import {RecipeComponent} from './components/recipe/recipe.component';
import {CollectionsComponent} from './components/collections/collections.component';
import {GlimpsesStore} from '../../stores/glimpses.store';
import {CollectionsStore} from '../../stores/collections.store';
import {CollectionsRemote} from './remotes/collections.remote';

@Component({
  selector: 'krk-home-page',
  standalone: true,
  imports: [
    TagsListComponent,
    GlimpseComponent,
    GlimpsesComponent,
    RecipeComponent,
    CollectionsComponent,
  ],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss',
  providers: [
    HomeService,
    RecipesRemote,
    TagsRemote,
    GlimpsesRemote,
    CollectionsRemote,
    GuidHelper,
  ],
})
export class HomePageComponent implements OnInit, OnDestroy {
  homeService = inject(HomeService);
  route = inject(ActivatedRoute);
  guidHelper = inject(GuidHelper);
  router = inject(Router);
  recipesStore = inject(RecipesStore);
  glimpsesStore = inject(GlimpsesStore);
  collectionsStore = inject(CollectionsStore);

  subscriptions = new Subscription();

  numberOfColumns = signal(1);

  firstBatchRecipes = computed(() => {
    return this.recipesStore.data().slice(0, this.numberOfColumns() * 2);
  })

  secondBatchRecipes = computed(() => {
    return this.recipesStore.data().slice(this.numberOfColumns() * 2, this.numberOfColumns() * 4);
  })

  thirdBatchRecipes = computed(() => {
    return this.recipesStore.data().slice(this.numberOfColumns() * 4);
  })

  hasGlimpses = computed(() => {
    return this.glimpsesStore.data().length > 0;
  })

  hasCollections = computed(() => {
    return this.collectionsStore.data().length > 0;
  })

  constructor() {
    // Set the initial number of columns based on the current window width
    this.updateNumberOfColumns(window.innerWidth);
  }

  @HostListener('window:resize', ['$event'])
  onResize(event: Event) {
    const target = event.target as Window;
    this.updateNumberOfColumns(target.innerWidth);
  }

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

  private updateNumberOfColumns(width: number) {
    let columns = 1;
    if (width >= 2421) {
      columns = 6;
    } else if (width >= 2044) {
      columns = 5;
    } else if (width >= 1700) {
      columns = 4;
    } else if (width >= 1350) {
      columns = 3;
    } else if (width >= 1010) {
      columns = 2;
    }
    this.numberOfColumns.set(columns);
  }
}
