import {Component, inject, Injector, OnInit} from '@angular/core';
import {BreadcrumbComponent} from './components/breadcrumb/breadcrumb.component';
import {NotificationButtonComponent} from './components/notification-button/notification-button.component';
import {ForkButtonComponent} from './components/fork-button/fork-button.component';
import {AddToCollectionButtonComponent} from './components/add-to-collection-button/add-to-collection-button.component';
import {LikeDislikeButtonsComponent} from './components/like-dislike-buttons/like-dislike-buttons.component';
import {CommentsButtonComponent} from './components/comments-button/comments-button.component';
import {ShareButtonComponent} from './components/share-button/share-button.component';
import {OthersButtonComponent} from './components/others-button/others-button.component';
import {DividerComponent} from './components/divider/divider.component';
import {RecipePageService} from './services/recipe-page.service';
import {RecipeRemote} from './remotes/recipe.remote';
import {ActivatedRoute, Router} from '@angular/router';
import {Subscription} from 'rxjs';
import {GuidHelper} from '@shared/helpers/guid.helper';
import {showSnackbarOnError} from '@shared/operators/show-snackbar-on-error.operator';

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
    DividerComponent
  ],
  templateUrl: './recipe-page.component.html',
  styleUrl: './recipe-page.component.scss',
  providers: [
    RecipePageService,
    RecipeRemote,
    GuidHelper
  ]
})
export class RecipePageComponent implements OnInit {
  service = inject(RecipePageService);
  guidHelper = inject(GuidHelper);
  injector = inject(Injector)

  route = inject(ActivatedRoute);
  router = inject(Router);

  subs = new Subscription()

  ngOnInit() {
    this.listenToRecipeIdChange();
  }

  listenToRecipeIdChange() {
    const sub = this.route.params.subscribe(params => {
      const recipeId = params['id'] as string;

      // return to user home page if recipe id is not guid
      if (!this.guidHelper.isGuid(recipeId)) {
        this.router.navigate(["user"]);
      }

      this.service.recipeId.set(recipeId);
      this.service.fetch(recipeId).pipe(
        showSnackbarOnError(this.injector)
      ).subscribe();
    })
    this.subs.add(sub);
  }
}
