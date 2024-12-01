import {Component, inject} from '@angular/core';
import {CollectionToAddComponent} from "./components/collection-to-add/collection-to-add.component";
import {RecipeToCollectionModalService} from '../../services/recipe-to-collection-modal.service';
import {LoaderComponent} from '@shared/components/loader/loader.component';

@Component({
  selector: 'krk-body',
  standalone: true,
  imports: [
    CollectionToAddComponent,
    LoaderComponent
  ],
  templateUrl: './body.component.html',
  styleUrl: './body.component.scss'
})
export class BodyComponent {
  service = inject(RecipeToCollectionModalService)

}
