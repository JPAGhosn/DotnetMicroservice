import {Component, computed, DestroyRef, effect, inject, OnInit, signal} from '@angular/core';
import {TabularContainerComponent} from '@shared/components/tabular-container/tabular-container.component';
import {
  TabularNavigationComponent
} from '@shared/components/tabular-container/components/tabular-navigation/tabular-navigation.component';
import {ActivatedRoute, Router, RouterLink, RouterLinkActive} from '@angular/router';
import {RecipePageService} from '../../services/recipe-page.service';
import {takeUntilDestroyed} from '@angular/core/rxjs-interop';
import {GuidHelper} from '@shared/helpers/guid.helper';
import {catchError, distinctUntilChanged, from, Subject, takeUntil, tap} from 'rxjs';
import {RepositoriesRemote} from '../../remotes/repositories.remote';
import {RepositoriesStore} from '../../../../stores/repositories.store';
import {BnaEditorComponent} from '@dytab/ngx-blocknote';
import {BlockNoteEditor} from '@blocknote/core';
import {EditButtonComponent} from './components/edit-button/edit-button.component';
import {SmallButtonComponent} from './components/small-button/small-button.component';
import {LoaderComponent} from './components/loader/loader.component';

@Component({
  selector: 'krk-recipe-page-tabular-descriptions',
  standalone: true,
  imports: [
    TabularContainerComponent,
    TabularNavigationComponent,
    RouterLink,
    RouterLinkActive,
    BnaEditorComponent,
    EditButtonComponent,
    SmallButtonComponent,
    LoaderComponent,
  ],
  templateUrl: './recipe-page-tabular-descriptions.component.html',
  styleUrl: './recipe-page-tabular-descriptions.component.scss',
})
export class RecipePageTabularDescriptionsComponent implements OnInit {
  route = inject(ActivatedRoute)
  destroyRef = inject(DestroyRef)
  guidHelper = inject(GuidHelper)
  router = inject(Router)
  repositoriesRemote = inject(RepositoriesRemote)
  repositoriesStore = inject(RepositoriesStore)

  pageService = inject(RecipePageService);

  editor = signal<BlockNoteEditor | null>(null);

  parseMarkdownCancel$ = new Subject();

  allowedFilenames = ["readme", "code-of-conduct", "license"];

  repository = computed(() => {
    const recipeId = this.pageService.recipeId();
    if (!recipeId) return null;

    return this.repositoriesStore.findById(recipeId) ?? null;
  })

  repositoryName = computed(() => {
    return this.repository()?.index.recipe.name ?? "";
  })

  creatorUserName = computed(() => {
    return this.pageService.recipe()?.creator.userName ?? "Unknown";
  })

  isReadMeSelected = computed(() => {
    const fileName = this.pageService.fileName();
    return fileName === "readme"
  })

  content = computed(() => {
    const recipeId = this.pageService.recipeId();
    const fileName = this.pageService.fileName();
    if (!recipeId || !fileName) {
      return null;
    }

    const repository = this.repository();
    if (!repository) return null;

    const contentMap: any = {
      "readme": repository.indexMd,
      "code-of-conduct": repository.codeOfConduct,
      "license": repository.license,
    }

    return contentMap[fileName];
  })
  isSaving = signal(false);
  private cancelled$ = new Subject();

  constructor() {
    effect(() => {
      const editor = this.editor();
      const content = this.content() ?? "";

      if (!editor) {
        return;
      }

      this.parseMarkdownCancel$.next(null);
      from(editor.tryParseMarkdownToBlocks(content)).pipe(
        takeUntilDestroyed(this.destroyRef),
        takeUntil(this.parseMarkdownCancel$),
        tap(blocks => {
          editor.replaceBlocks(editor.document, blocks)
        }),
        catchError(err => {
          throw err
        })
      ).subscribe()
    });

    effect(() => {
      if (this.pageService.editMode()) {
        this.enableEditing()
      } else {
        this.disableEditing()
      }
    }, {allowSignalWrites: true});
  }

  ngOnInit() {
    this.listenToFileNameChange();
  }

  listenToFileNameChange() {
    this.route.paramMap.pipe(
      takeUntilDestroyed(this.destroyRef),
      distinctUntilChanged()
    ).subscribe((params) => {

      const recipeId = params.get('id')!;
      if (!this.guidHelper.isGuid(recipeId)) {
        throw "recipeId is not a GUID"
      }

      const fileName = params.get('fileName')!;
      if (!this.allowedFilenames.includes(fileName)) {
        this.router.navigate(["..", "readme"], {relativeTo: this.route});
        return;
      }

      this.pageService.fileName.set(fileName)

      this.pageService.fetchRepository(recipeId).pipe(
        takeUntilDestroyed(this.destroyRef),
        takeUntil(this.cancelled$),
      ).subscribe()
    })
  }

  onEditorReady(editor: BlockNoteEditor) {
    this.editor.set(editor)
    // Prevent showing formatting
    this.editor()!.formattingToolbar.onUpdate(c => {
      if (!this.pageService.editMode()) {
        this.editor()!.formattingToolbar.closeMenu()
      }
    })
  }

  onRecipeNameChange($event: Event) {
  }

  onSaveClicked() {
    this.isSaving.set(true)
  }

  onCancelClicked() {
  }

  private disableEditing() {
    this.editor()!.isEditable = false;
  }

  private enableEditing() {
    this.editor()!.isEditable = true;
  }
}
