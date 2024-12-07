import {Component, HostListener, inject, Input} from '@angular/core';
import {RecipeModel} from '../../models/recipe.model';
import {NgOptimizedImage} from '@angular/common';
import {ImageComponent} from '@shared/components/image/image.component';
import {AvatarComponent} from '../../../../components/avatar/avatar.component';
import {MediaInformationComponent} from '../../../../components/media-information/media-information.component';
import {Router} from '@angular/router';

@Component({
  selector: 'krk-recipe',
  standalone: true,
  imports: [
    NgOptimizedImage,
    ImageComponent,
    AvatarComponent,
    MediaInformationComponent
  ],
  templateUrl: './recipe.component.html',
  styleUrl: './recipe.component.scss'
})
export class RecipeComponent {
  router = inject(Router)

  @Input({required: true}) recipe!: RecipeModel;

  @HostListener("click")
  private onClick() {
    this.router.navigate(["user", "recipes", this.recipe.id]);
  }
}
