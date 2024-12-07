import {Component, Input} from '@angular/core';
import {CollectionModel} from '../../../../../../../../../home-page/models/collection.model';
import {CollectionComponent} from '../../../../../../../../../../components/collection/collection.component';
import {AddButtonComponent} from '../add-button/add-button.component';
import {IconButtonComponent} from '../../../../../../../../../../components/icon-button/icon-button.component';
import {NgTemplateOutlet} from '@angular/common';

@Component({
  selector: 'krk-collection-to-add',
  standalone: true,
  imports: [
    CollectionComponent,
    AddButtonComponent,
    IconButtonComponent,
    NgTemplateOutlet
  ],
  templateUrl: './collection-to-add.component.html',
  styleUrl: './collection-to-add.component.scss'
})
export class CollectionToAddComponent {
  @Input({required: true}) collection!: CollectionModel;
}
