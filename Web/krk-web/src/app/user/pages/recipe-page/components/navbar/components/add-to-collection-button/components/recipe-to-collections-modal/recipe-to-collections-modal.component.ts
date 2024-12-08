import {Component, inject, OnInit} from '@angular/core';
import {SearchBarComponent} from '../../../../../../../../components/search-bar/search-bar.component';
import {IconButtonComponent} from '../../../../../../../../components/icon-button/icon-button.component';
import {HttpClient} from '@angular/common/http';
import {RecipeToCollectionModalService} from './services/recipe-to-collection-modal.service';
import {RecipeToCollectionModalRemote} from './remotes/recipe-to-collection-modal.remote';
import {CollectionToAddComponent} from './components/body/components/collection-to-add/collection-to-add.component';
import {HeaderComponent} from './components/header/header.component';
import {BodyComponent} from './components/body/body.component';
import {FooterComponent} from './components/footer/footer.component';

@Component({
  selector: 'krk-recipe-to-collections-modal',
  standalone: true,
  imports: [
    SearchBarComponent,
    IconButtonComponent,
    CollectionToAddComponent,
    HeaderComponent,
    BodyComponent,
    FooterComponent
  ],
  templateUrl: './recipe-to-collections-modal.component.html',
  styleUrl: './recipe-to-collections-modal.component.scss',
  providers: [
    RecipeToCollectionModalService,
    RecipeToCollectionModalRemote
  ]
})
export class RecipeToCollectionsModalComponent implements OnInit {
  http = inject(HttpClient)
  service = inject(RecipeToCollectionModalService)

  ngOnInit() {
    this.fetchCollections();
  }

  fetchCollections() {
    this.service.fetchCollections().subscribe();
  }
}
