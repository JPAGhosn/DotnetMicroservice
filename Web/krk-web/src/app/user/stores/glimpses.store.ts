import {BaseDataStore} from '@shared/store/base/data-base.store';
import {GlimpseModel} from '../pages/home-page/models/glimpse.model';
import {Injectable} from '@angular/core';

@Injectable()
export class GlimpsesStore extends BaseDataStore<GlimpseModel> {

}
