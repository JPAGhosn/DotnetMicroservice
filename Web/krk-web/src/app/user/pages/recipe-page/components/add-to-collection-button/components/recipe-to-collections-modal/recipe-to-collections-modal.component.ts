import {Component} from '@angular/core';
import {SearchBarComponent} from '../../../../../../components/search-bar/search-bar.component';
import {IconButtonComponent} from '../../../../../../components/icon-button/icon-button.component';

@Component({
  selector: 'krk-recipe-to-collections-modal',
  standalone: true,
  imports: [
    SearchBarComponent,
    IconButtonComponent
  ],
  templateUrl: './recipe-to-collections-modal.component.html',
  styleUrl: './recipe-to-collections-modal.component.scss'
})
export class RecipeToCollectionsModalComponent {

}
