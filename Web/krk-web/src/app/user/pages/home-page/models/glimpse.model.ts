import {MediaModel} from './media.model';

export interface GlimpseModel extends MediaModel {
  creatorId: string;
  videoPath: string;
  thumbnailPath: string;
}
