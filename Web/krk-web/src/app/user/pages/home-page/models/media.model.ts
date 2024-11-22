import {BaseModel} from '@shared/models/base/base.model';
import {ProfileModel} from '../../../components/side-bar/components/subscribtions/models/profile.model';

export interface MediaModel extends BaseModel {
  creator: ProfileModel;
  name: string;
  numberOfViews: number;
  publishedDate: Date
}
