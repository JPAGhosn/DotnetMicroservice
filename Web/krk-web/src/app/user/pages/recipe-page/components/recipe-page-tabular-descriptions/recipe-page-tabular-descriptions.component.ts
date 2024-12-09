import {Component} from '@angular/core';
import {TabularContainerComponent} from '@shared/components/tabular-container/tabular-container.component';

@Component({
  selector: 'krk-recipe-page-tabular-descriptions',
  standalone: true,
  imports: [
    TabularContainerComponent
  ],
  templateUrl: './recipe-page-tabular-descriptions.component.html',
  styleUrl: './recipe-page-tabular-descriptions.component.scss'
})
export class RecipePageTabularDescriptionsComponent {

}
