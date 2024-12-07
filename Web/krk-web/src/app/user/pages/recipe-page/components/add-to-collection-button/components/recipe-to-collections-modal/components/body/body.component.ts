import {Component, inject} from '@angular/core';
import {CollectionToAddComponent} from "./components/collection-to-add/collection-to-add.component";
import {RecipeToCollectionModalService} from '../../services/recipe-to-collection-modal.service';
import {LoaderComponent} from '@shared/components/loader/loader.component';
import {CollectionToCreateComponent} from './components/collection-to-create/collection-to-create.component';

@Component({
  selector: 'krk-body',
  standalone: true,
  imports: [
    CollectionToAddComponent,
    LoaderComponent,
    CollectionToCreateComponent,
    CollectionToCreateComponent
  ],
  templateUrl: './body.component.html',
  styleUrl: './body.component.scss'
})
export class BodyComponent {
  service = inject(RecipeToCollectionModalService)
}

