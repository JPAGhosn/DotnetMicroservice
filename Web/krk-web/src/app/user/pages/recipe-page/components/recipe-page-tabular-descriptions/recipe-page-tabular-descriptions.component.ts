import {Component, computed, DestroyRef, inject, OnInit} from '@angular/core';
import {TabularContainerComponent} from '@shared/components/tabular-container/tabular-container.component';
import {
  TabularNavigationComponent
} from '@shared/components/tabular-container/components/tabular-navigation/tabular-navigation.component';
import {ActivatedRoute, Router, RouterLink, RouterLinkActive} from '@angular/router';
import {RecipePageService} from '../../services/recipe-page.service';
import {takeUntilDestroyed} from '@angular/core/rxjs-interop';
import {GuidHelper} from '@shared/helpers/guid.helper';
import {distinctUntilChanged, Subject, takeUntil} from 'rxjs';
import {RepositoriesRemote} from '../../remotes/repositories.remote';
import {RepositoriesStore} from '../../../../stores/repositories.store';
import {BnaEditorComponent} from '@dytab/ngx-blocknote';

@Component({
  selector: 'krk-recipe-page-tabular-descriptions',
  standalone: true,
  imports: [
    TabularContainerComponent,
    TabularNavigationComponent,
    RouterLink,
    RouterLinkActive,
    BnaEditorComponent,
  ],
  templateUrl: './recipe-page-tabular-descriptions.component.html',
  styleUrl: './recipe-page-tabular-descriptions.component.scss'
})
export class RecipePageTabularDescriptionsComponent implements OnInit {
  route = inject(ActivatedRoute)
  destroyRef = inject(DestroyRef)
  guidHelper = inject(GuidHelper)
  router = inject(Router)
  repositoriesRemote = inject(RepositoriesRemote)
  repositoriesStore = inject(RepositoriesStore)

  pageService = inject(RecipePageService);

  allowedFilenames = ["readme", "code-of-conduct", "license"];
  content = computed(() => {
    const recipeId = this.pageService.recipeId();
    const fileName = this.pageService.fileName();
    if (!recipeId || !fileName) {
      return null;
    }

    const repository = this.repositoriesStore.findById(recipeId);
    if (!repository) return null;

    const contentMap: any = {
      "readme": repository.indexMd,
      "code-of-conduct": repository.codeOfConduct,
      "license": repository.license,
    }

    return contentMap[fileName];
  })
  private cancelled$ = new Subject();

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
}
