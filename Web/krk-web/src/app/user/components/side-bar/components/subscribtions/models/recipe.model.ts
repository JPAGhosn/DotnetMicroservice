import {ProfileModel} from './profile.model';
import {BaseModel} from '@shared/models/base/base.model';

export interface RecipeModel extends BaseModel {
  name: string;
  cover?: string;
  creator: ProfileModel;
  numberOfViews: number;
  publishedDate: Date;
}
