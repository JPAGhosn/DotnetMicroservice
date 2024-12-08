import {Component, DestroyRef, inject, Injector, OnInit} from '@angular/core';
import {BreadcrumbComponent} from './components/navbar/components/breadcrumb/breadcrumb.component';
import {
  NotificationButtonComponent
} from './components/navbar/components/notification-button/notification-button.component';
import {ForkButtonComponent} from './components/navbar/components/fork-button/fork-button.component';
import {
  AddToCollectionButtonComponent
} from './components/navbar/components/add-to-collection-button/add-to-collection-button.component';
import {
  LikeDislikeButtonsComponent
} from './components/navbar/components/like-dislike-buttons/like-dislike-buttons.component';
import {CommentsButtonComponent} from './components/navbar/components/comments-button/comments-button.component';
import {ShareButtonComponent} from './components/navbar/components/share-button/share-button.component';
import {OthersButtonComponent} from './components/navbar/components/others-button/others-button.component';
import {DividerComponent} from './components/navbar/components/divider/divider.component';
import {RecipePageService} from './services/recipe-page.service';
import {RecipeRemote} from './remotes/recipe.remote';
import {ActivatedRoute, Router} from '@angular/router';
import {GuidHelper} from '@shared/helpers/guid.helper';
import {showSnackbarOnError} from '@shared/operators/show-snackbar-on-error.operator';
import {takeUntilDestroyed} from '@angular/core/rxjs-interop';
import {NavbarComponent} from './components/navbar/navbar.component';
import {RecipePageCoverComponent} from './components/recipe-page-cover/recipe-page-cover.component';
import {
  RecipePageTabularDescriptionsComponent
} from './components/recipe-page-tabular-descriptions/recipe-page-tabular-descriptions.component';
import {RecipePageTagsComponent} from './components/recipe-page-tags/recipe-page-tags.component';
import {RecipePageInformationComponent} from './components/recipe-page-information/recipe-page-information.component';
import {RecipePageMacrosComponent} from './components/recipe-page-macros/recipe-page-macros.component';
import {
  RecipePageExtraInformationComponent
} from './components/recipe-page-extra-information/recipe-page-extra-information.component';
import {RecipePageReleasesComponent} from './components/recipe-page-releases/recipe-page-releases.component';
import {RecipePageUsedByComponent} from './components/recipe-page-used-by/recipe-page-used-by.component';
import {
  RecipePageContributorsComponent
} from './components/recipe-page-contributors/recipe-page-contributors.component';
import {RecipePageSuggestionsComponent} from './components/recipe-page-suggestions/recipe-page-suggestions.component';
import {forkJoin} from 'rxjs';
import {preventErrorPropagation} from '@shared/operators/prevent-error.operator';
import {RepositoriesRemote} from './remotes/repositories.remote';

@Component({
  selector: 'krk-recipe-page',
  standalone: true,
  imports: [
    BreadcrumbComponent,
    NotificationButtonComponent,
    ForkButtonComponent,
    AddToCollectionButtonComponent,
    LikeDislikeButtonsComponent,
    CommentsButtonComponent,
    ShareButtonComponent,
    OthersButtonComponent,
    DividerComponent,
    NavbarComponent,
    RecipePageCoverComponent,
    RecipePageTabularDescriptionsComponent,
    RecipePageTagsComponent,
    RecipePageInformationComponent,
    RecipePageMacrosComponent,
    RecipePageExtraInformationComponent,
    RecipePageReleasesComponent,
    RecipePageUsedByComponent,
    RecipePageContributorsComponent,
    RecipePageSuggestionsComponent
  ],
  templateUrl: './recipe-page.component.html',
  styleUrl: './recipe-page.component.scss',
  providers: [
    RecipePageService,
    RecipeRemote,
    RepositoriesRemote,
    GuidHelper
  ]
})
export class RecipePageComponent implements OnInit {
  service = inject(RecipePageService);
  guidHelper = inject(GuidHelper);
  injector = inject(Injector)

  route = inject(ActivatedRoute);
  router = inject(Router);

  destroyRef = inject(DestroyRef)

  ngOnInit() {
    this.listenToRecipeIdChange();
  }

  listenToRecipeIdChange() {
    this.route.params.pipe(
      takeUntilDestroyed(this.destroyRef)
    ).subscribe(params => {
      const recipeId = params['id'] as string;

      // return to user home page if recipe id is not guid
      if (!this.guidHelper.isGuid(recipeId)) {
        this.router.navigate(["user"]);
      }

      this.service.recipeId.set(recipeId);
      forkJoin({
        recipe: this.fetchRecipe(recipeId).pipe(preventErrorPropagation()),
        repository: this.fetchRepository(recipeId).pipe(preventErrorPropagation()),
      }).subscribe();
    })
  }

  fetchRecipe(recipeId: string) {
    return this.service.fetchRecipe(recipeId).pipe(
      takeUntilDestroyed(this.destroyRef),
      showSnackbarOnError(this.injector)
    )
  }

  fetchRepository(recipeId: string) {
    return this.service.fetchRepository(recipeId).pipe(
      takeUntilDestroyed(this.destroyRef),
      showSnackbarOnError(this.injector)
    )
  }
}
