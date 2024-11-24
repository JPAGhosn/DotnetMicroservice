import {Component} from '@angular/core';
import {ImageComponent} from "@shared/components/image/image.component";
import {MediaInformationComponent} from "../media-information/media-information.component";

@Component({
  selector: 'krk-recipe-skeleton',
  standalone: true,
  imports: [
    ImageComponent,
    MediaInformationComponent,
  ],
  templateUrl: './recipe-skeleton.component.html',
  styleUrl: './recipe-skeleton.component.scss'
})
export class RecipeSkeletonComponent {

}
