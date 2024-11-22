import {MediaModel} from './media.model';

export interface GlimpseModel extends MediaModel {
  videoPath: string;
  thumbnailPath: string;
}
