import {ProfileModel} from '../../../components/side-bar/components/subscribtions/models/profile.model';
import {MediaModel} from './media.model';

export interface RecipeModel extends MediaModel {
  name: string;
  cover?: string;
  creator: ProfileModel;
  numberOfViews: number;
  publishedDate: Date;
}
