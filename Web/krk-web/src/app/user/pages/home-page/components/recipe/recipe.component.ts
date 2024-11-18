import {Component, Input} from '@angular/core';
import {RecipeModel} from '../../../../components/side-bar/components/subscribtions/models/recipe.model';
import {NgOptimizedImage} from '@angular/common';
import {ImageComponent} from '@shared/components/image/image.component';
import {AvatarComponent} from '../../../../components/avatar/avatar.component';

@Component({
  selector: 'krk-recipe',
  standalone: true,
  imports: [
    NgOptimizedImage,
    ImageComponent,
    AvatarComponent
  ],
  templateUrl: './recipe.component.html',
  styleUrl: './recipe.component.scss'
})
export class RecipeComponent {
  @Input({required: true}) recipe!: RecipeModel;
}
