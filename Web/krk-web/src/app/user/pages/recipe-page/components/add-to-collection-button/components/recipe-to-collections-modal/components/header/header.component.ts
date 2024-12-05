import {Component, inject} from '@angular/core';
import {IconButtonComponent} from "../../../../../../../../components/icon-button/icon-button.component";
import {SearchBarComponent} from "../../../../../../../../components/search-bar/search-bar.component";
import {ReactiveFormsModule} from '@angular/forms';
import {RecipeToCollectionModalService} from '../../services/recipe-to-collection-modal.service';
import {Subject, takeUntil} from 'rxjs';

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
export class HeaderComponent {
  modalService = inject(RecipeToCollectionModalService)

  cancellationSubject$ = new Subject();

  OnSearchChange() {
    this.cancellationSubject$.next(null)
    this.modalService.fetchCollections().pipe(
      takeUntil(this.cancellationSubject$)
    ).subscribe();
  }
}
