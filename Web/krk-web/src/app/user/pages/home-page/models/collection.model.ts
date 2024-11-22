import {MediaModel} from './media.model';

export interface CollectionModel extends MediaModel {
  videoPath: string;
  numberOfFollowers: number;
  coverPath1: string | null;
  coverPath2: string | null;
  coverPath3: string | null;
}
