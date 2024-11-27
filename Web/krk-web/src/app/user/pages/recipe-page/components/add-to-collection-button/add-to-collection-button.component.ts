import {AfterViewInit, Component, inject, TemplateRef, ViewChild} from '@angular/core';
import {NavbarButtonComponent} from '../navbar-button/navbar-button.component';
import {NgOptimizedImage} from '@angular/common';
import {CollectionsService} from './services/collections.service';
import {CollectionsRemote} from './remotes/collections.remote';
import {ModalsService} from '@shared/components/modals/services/modals.service';
import {
  RecipeToCollectionsModalComponent
} from './components/recipe-to-collections-modal/recipe-to-collections-modal.component';

@Component({
  selector: 'krk-add-to-collection-button',
  standalone: true,
  imports: [
    NavbarButtonComponent,
    NgOptimizedImage,
    RecipeToCollectionsModalComponent
  ],
  templateUrl: './add-to-collection-button.component.html',
  styleUrl: './add-to-collection-button.component.scss',
  providers: [
    CollectionsService,
    CollectionsRemote
  ]
})
export class AddToCollectionButtonComponent implements AfterViewInit {
  service = inject(CollectionsService)
  modalsService = inject(ModalsService)

  @ViewChild("addToCollection")
  addToCollectionModal!: TemplateRef<any>;

  ngAfterViewInit() {
    this.modalsService.showModal(this.addToCollectionModal)
  }

  onCLick() {
    this.showCollectionsModal();
  }

  showCollectionsModal() {
    this.modalsService.showModal(this.addToCollectionModal);
  }

  addToCollection() {
    // this.service.addRecipeToCollection().subscribe();
  }
}
