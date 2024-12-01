import {Component, computed, inject} from '@angular/core';
import {ImageComponent} from '@shared/components/image/image.component';
import {RecipeToCollectionModalService} from '../../services/recipe-to-collection-modal.service';

@Component({
  selector: 'krk-footer',
  standalone: true,
  imports: [
    ImageComponent
  ],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.scss'
})
export class FooterComponent {
  service = inject(RecipeToCollectionModalService)

  recipeImage = computed(() => {
    return this.service.recipe()?.cover;
  })

  recipeName = computed(() => {
    return this.service.recipe()?.name;
  })
}
