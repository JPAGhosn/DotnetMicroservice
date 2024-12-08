import {AfterViewInit, Component, DestroyRef, inject} from '@angular/core';
import {IconButtonComponent} from "../../../../../../../../../../components/icon-button/icon-button.component";
import {SearchBarComponent} from "../../../../../../../../../../components/search-bar/search-bar.component";
import {ReactiveFormsModule} from '@angular/forms';
import {RecipeToCollectionModalService} from '../../services/recipe-to-collection-modal.service';
import {debounceTime, distinctUntilChanged, Subject, takeUntil, tap} from 'rxjs';
import {CollectionsStore} from '../../../../../../../../../../stores/collections.store';
import {takeUntilDestroyed} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-header',
  standalone: true,
  imports: [
    IconButtonComponent,
    SearchBarComponent,
    ReactiveFormsModule
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent implements AfterViewInit {
  modalService = inject(RecipeToCollectionModalService)
  cancellationSubject$ = new Subject();
  collectionsStore = inject(CollectionsStore)
  destroyRef$ = inject(DestroyRef)

  ngAfterViewInit() {
    this.registerOnSearchChange()
  }

  onAddIconClicked() {
    this.modalService.showCollectionCreateTemplate();
  }

  private registerOnSearchChange() {
    this.modalService.searchControl.valueChanges.pipe(
      takeUntilDestroyed(this.destroyRef$),
      tap(value => {
        this.cancellationSubject$.next(null)
      }),
      debounceTime(200),
      distinctUntilChanged(),
      tap(value => {
        this.modalService.fetchCollections().pipe(
          takeUntil(this.cancellationSubject$),
        ).subscribe();
      })
    ).subscribe()
  }
}
