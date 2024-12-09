import {Component, computed, inject} from '@angular/core';
import {ImageComponent} from '@shared/components/image/image.component';
import {RecipePageService} from '../../services/recipe-page.service';
import {RepositoriesStore} from '../../../../stores/repositories.store';
import {StartCookingButtonComponent} from './components/start-cooking-button/start-cooking-button.component';

@Component({
  selector: 'krk-recipe-page-cover',
  standalone: true,
  imports: [
    ImageComponent,
    StartCookingButtonComponent,
  ],
  templateUrl: './recipe-page-cover.component.html',
  styleUrl: './recipe-page-cover.component.scss'
})
export class RecipePageCoverComponent {
  pageService = inject(RecipePageService)
  repositoriesStore = inject(RepositoriesStore);

  selectedRepository = computed(() => {
    const recipeId = this.pageService.recipeId()!;
    const repository = this.repositoriesStore.findById(recipeId)!;
    return repository;
  })
}
