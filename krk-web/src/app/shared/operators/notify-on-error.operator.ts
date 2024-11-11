import {catchError, Observable, throwError} from 'rxjs';
import {Injector} from '@angular/core';

export function notifyOnError<T>(injector: Injector) {
  return (source: Observable<T>) => {
    return source.pipe(
      catchError(err => {
        console.error(err)
        return throwError(() => err);
      })
    );
  };
}
