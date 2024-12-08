import {Component, computed, inject, Input} from '@angular/core';
import {IconButtonComponent} from '../../../../../../../../../../../../components/icon-button/icon-button.component';
import {NgTemplateOutlet} from '@angular/common';
import {RecipeToCollectionModalService} from '../../../../services/recipe-to-collection-modal.service';
import {CollectionModel} from '../../../../../../../../../../../home-page/models/collection.model';
import {AddButtonRemote} from './remotes/add-button.remote';
import {RecipePageService} from '../../../../../../../../../../services/recipe-page.service';
import {catchError, Subject, takeUntil, throwError} from 'rxjs';

@Component({
  selector: 'krk-add-button',
  standalone: true,
  imports: [
    IconButtonComponent,
    NgTemplateOutlet
  ],
  templateUrl: './add-button.component.html',
  styleUrl: './add-button.component.scss',
  providers: [AddButtonRemote],
})
export class AddButtonComponent {
  recipeToCollectionsModalService = inject(RecipeToCollectionModalService)
  addButtonRemote = inject(AddButtonRemote);
  pageService = inject(RecipePageService)

  stopRequestSubject$: Subject<boolean> = new Subject<boolean>();

  @Input({required: false}) collection?: CollectionModel;
  @Input({required: false}) checked = false;
  @Input({required: false}) clickable = true;
  addedToCollection = computed(() => {
    if (!this.collection) return this.checked;

    return this.recipeToCollectionsModalService.chosenCollectionIds().includes(this.collection.id)
  })

  // Adding/Removing the recipe from a collection.

  // This will be added asynchronously with the api.
  onIconButtonClicked() {
    if (!this.collection) return;

    this.stopRequestSubject$.next(true);

    const currentCollectionsIds = [...this.recipeToCollectionsModalService.chosenCollectionIds()];

    if (currentCollectionsIds.findIndex(projectId => projectId === this.collection!.id) === -1) {
      currentCollectionsIds.push(this.collection.id)
      this.addButtonRemote.addToCollection(this.collection.id, this.pageService.recipeId()!).pipe(
        takeUntil(this.stopRequestSubject$),
        catchError(err => {
          const index = currentCollectionsIds.findIndex(projectId => projectId === this.collection!.id);
          currentCollectionsIds.splice(index, 1)
          this.recipeToCollectionsModalService.chosenCollectionIds.set([...currentCollectionsIds]);
          return throwError(() => err);
        })
      ).subscribe();
    } else {
      currentCollectionsIds.splice(currentCollectionsIds.indexOf(this.collection.id), 1);
      this.addButtonRemote.removeFromCollection(this.collection.id, this.pageService.recipeId()!).pipe(
        takeUntil(this.stopRequestSubject$),
        catchError(err => {
          currentCollectionsIds.push(this.collection!.id);
          this.recipeToCollectionsModalService.chosenCollectionIds.set([...currentCollectionsIds]);
          return throwError(() => err);
        })
      ).subscribe();
    }

    this.recipeToCollectionsModalService.chosenCollectionIds.set(currentCollectionsIds);

  }
}
