import {Component, inject} from '@angular/core';
import {IconButtonComponent} from '../../../../../../components/icon-button/icon-button.component';
import {RecipePageService} from '../../../../services/recipe-page.service';

@Component({
  selector: 'krk-edit-button',
  standalone: true,
  imports: [
    IconButtonComponent
  ],
  templateUrl: './edit-button.component.html',
  styleUrl: './edit-button.component.scss'
})
export class EditButtonComponent {

  pageService = inject(RecipePageService)

  onClick() {
    const editMode = this.pageService.editMode();
    this.pageService.editMode.set(!editMode)
  }
}
