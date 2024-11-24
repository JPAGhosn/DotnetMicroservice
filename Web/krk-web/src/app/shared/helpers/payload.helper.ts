import {Injectable} from '@angular/core';

@Injectable()
export class PayloadHelper {
  processQueryParams(queryParams: any): any {
    const payload = {...queryParams} as any;

    if (payload.tagId === "") {
      delete payload.tagId;
    }

    return payload;
  }
}
