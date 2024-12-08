import {catchError, Observable, of} from 'rxjs';

// Used in case you have many remote calls from the many api using forkjoin
// and the issue is that forkjoin cancels all the other apis if one of them fails
export function preventErrorPropagation<T>() {
  return (source: Observable<T>) => {
    return source.pipe(
      catchError(err => {
        return of(null)
      })
    );
  };
}
