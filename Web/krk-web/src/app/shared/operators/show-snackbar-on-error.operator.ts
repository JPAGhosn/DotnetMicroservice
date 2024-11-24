import {catchError, Observable, throwError} from 'rxjs';
import {Injector} from '@angular/core';
import {SnackbarService} from '@shared/services/snackbar.service';
import {BaseError} from '@shared/models/base/base-error';

// Used in case you have many remote calls from the many api using forkjoin
// and the issue is that forkjoin cancels all the other apis if one of them fails
export function showSnackbarOnError<T>(injector: Injector) {
  return (source: Observable<T>) => {
    const snackbarService = injector.get(SnackbarService);

    return source.pipe(
      catchError(err => {
        const error = err as BaseError;
        snackbarService.showError(error);
        return throwError(() => err);
      })
    );
  };
}
