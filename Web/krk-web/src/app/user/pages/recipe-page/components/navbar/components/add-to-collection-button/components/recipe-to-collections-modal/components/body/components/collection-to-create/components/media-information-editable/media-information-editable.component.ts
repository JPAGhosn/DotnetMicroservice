import {
  AfterViewInit,
  Component,
  ElementRef,
  inject,
  Injector,
  Input,
  OnDestroy,
  signal,
  ViewChild
} from '@angular/core';
import {AvatarComponent} from '../../../../../../../../../../../../../../components/avatar/avatar.component';
import {DatePipe} from '@angular/common';
import {finalize, Subject, switchMap, tap} from 'rxjs';
import {FormsModule} from '@angular/forms';
import {MediaInformationEditableRemote} from './remotes/media-information-editable.remote';
import {RecipeToCollectionModalService} from '../../../../../../services/recipe-to-collection-modal.service';
import {showSnackbarOnError} from '@shared/operators/show-snackbar-on-error.operator';
import {RecipePageService} from '../../../../../../../../../../../../services/recipe-page.service';
import {SnackbarService} from '@shared/services/snackbar.service';

@Component({
  selector: 'krk-media-information-editable',
  standalone: true,
  imports: [
    AvatarComponent,
    DatePipe,
    FormsModule
  ],
  templateUrl: './media-information-editable.component.html',
  styleUrl: './media-information-editable.component.scss',
  providers: [
    MediaInformationEditableRemote
  ]
})
export class MediaInformationEditableComponent implements AfterViewInit, OnDestroy {

  @Input({required: true}) minimalInformation1?: string;

  @ViewChild("input") input!: ElementRef;

  submitted = false;

  publishedDate = signal(new Date())
  userName = signal("Unknown")
  destroyed$: Subject<void> = new Subject();
  value = signal("");

  private remote = inject(MediaInformationEditableRemote);
  private modalService = inject(RecipeToCollectionModalService);
  private pageService = inject(RecipePageService);
  private injector = inject(Injector);
  private snackbarService = inject(SnackbarService);

  ngAfterViewInit(): void {
    this.input.nativeElement.focus()
  }

  onValueChange(event: any) {
    this.value.set(event.target!.value ?? "");
  }

  onBlurInput() {
    if (!this.submitted) {
      this.submitted = true;
      this.createNewCollection()
    }
  }

  onEnterKeyUpInput() {
    if (!this.submitted) {
      this.submitted = true;
      this.createNewCollection()
    }
  }

  ngOnDestroy() {
    this.destroyed$.next()
  }

  private createNewCollection() {
    this.modalService.loading.set(true)
    this.remote.createCollection(this.pageService.recipeId()!, this.value()).pipe(
      tap(response => {
        this.snackbarService.showSuccess("Collection Creation Successful", "Collection created successfully and recipe was added to this collection.");
      }),
      switchMap(response => {
        return this.modalService.fetchCollections()
      }),
      showSnackbarOnError(this.injector),
      finalize(() => {
        this.modalService.hideCollectionCreateTemplate()
        this.modalService.loading.set(false)
      })
    ).subscribe()
  }
}
