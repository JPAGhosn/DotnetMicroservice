import {Component} from '@angular/core';
import {BreadcrumbComponent} from './components/breadcrumb/breadcrumb.component';
import {
  NotificationButtonComponent
} from './components/breadcrumb/components/notification-button/notification-button.component';
import {ForkButtonComponent} from './components/breadcrumb/components/fork-button/fork-button.component';
import {
  AddToCollectionButtonComponent
} from './components/breadcrumb/components/add-to-collection-button/add-to-collection-button.component';
import {
  LikeDislikeButtonsComponent
} from './components/breadcrumb/components/like-dislike-buttons/like-dislike-buttons.component';
import {CommentsButtonComponent} from './components/breadcrumb/components/comments-button/comments-button.component';
import {ShareButtonComponent} from './components/breadcrumb/components/share-button/share-button.component';
import {OthersButtonComponent} from './components/breadcrumb/components/others-button/others-button.component';
import {DividerComponent} from './components/breadcrumb/components/divider/divider.component';

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
  styleUrl: './recipe-page.component.scss'
})
export class RecipePageComponent {

}
