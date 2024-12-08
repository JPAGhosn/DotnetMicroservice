import {Component} from '@angular/core';
import {AddToCollectionButtonComponent} from "./components/add-to-collection-button/add-to-collection-button.component";
import {BreadcrumbComponent} from "./components/breadcrumb/breadcrumb.component";
import {CommentsButtonComponent} from "./components/comments-button/comments-button.component";
import {DividerComponent} from "./components/divider/divider.component";
import {LikeDislikeButtonsComponent} from "./components/like-dislike-buttons/like-dislike-buttons.component";
import {NotificationButtonComponent} from "./components/notification-button/notification-button.component";
import {OthersButtonComponent} from "./components/others-button/others-button.component";
import {ShareButtonComponent} from "./components/share-button/share-button.component";

@Component({
  selector: 'krk-navbar',
  standalone: true,
  imports: [
    AddToCollectionButtonComponent,
    BreadcrumbComponent,
    CommentsButtonComponent,
    DividerComponent,
    LikeDislikeButtonsComponent,
    NotificationButtonComponent,
    OthersButtonComponent,
    ShareButtonComponent
  ],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss'
})
export class NavbarComponent {

}
