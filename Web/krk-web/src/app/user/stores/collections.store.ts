import {BaseDataStore} from '@shared/store/base/data-base.store';
import {Injectable} from '@angular/core';
import {CollectionModel} from '../pages/home-page/models/collection.model';

@Injectable()
export class CollectionsStore extends BaseDataStore<CollectionModel> {

}
