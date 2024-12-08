import {IndexModel} from '../models/index.model';
import {InstructionsModel} from '../models/instructions.model';
import {BaseModel} from '@shared/models/base/base.model';

export interface RepositoryModel extends BaseModel {
  index: IndexModel;
  indexMd: string;
  instructions: InstructionsModel;
  License: string;
  codeOfConduct: string;
}
