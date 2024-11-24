import {Component, computed, inject} from '@angular/core';
import {RecipePageService} from '../../services/recipe-page.service';

@Component({
  selector: 'krk-breadcrumb',
  standalone: true,
  imports: [],
  templateUrl: './breadcrumb.component.html',
  styleUrl: './breadcrumb.component.scss'
})
export class BreadcrumbComponent {
  service = inject(RecipePageService);

  userName = computed(() => {
    return this.service.profile()?.userName
  })

  recipeSlug = computed(() => {
    return this.service.recipe()?.slug
  })
}
