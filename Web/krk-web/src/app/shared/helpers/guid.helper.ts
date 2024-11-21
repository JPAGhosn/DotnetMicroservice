import {Injectable} from '@angular/core';
import * as uuid from 'uuid';

@Injectable()
export class GuidHelper {
  isGuid(guid: string) {
    return uuid.validate(guid);
  }
}
