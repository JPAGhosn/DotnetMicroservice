import {MediaModel} from '../../../../../../home-page/models/media.model';

export interface CollectionOwnerViewDto extends MediaModel {
  videoPath: string;
  numberOfFollowers: number;
  coverPath1: string | null;
  coverPath2: string | null;
  coverPath3: string | null;
  isRecipeAdded: boolean;
}
