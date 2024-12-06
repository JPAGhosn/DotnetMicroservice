import {catchError, Observable, throwError} from 'rxjs';
import {BaseError} from '@shared/models/base/base-error';

export function handleRemoteError<T>() {
  return (source: Observable<T>) => {
    return source.pipe(
      catchError(err => {
        console.log("Root error", err)
        return throwError(() => {
          // Remote errors
          const error: BaseError = {
            code: err.error?.code,
            description: err.error?.description,
            title: err.error?.title,
            statusCode: err.error.statusCode,
          }

          // Handle on device errors
          if (!error.code) {
            if (err.name === "HttpErrorResponse") {
              error.code = "CannotConnectToServerError";
              error.description = "An error occurred while trying to connect to the server. Check your internet connection then try again.";
              error.title = "Cannot connect to the server";
            } else {
              error.code = "UnknownError";
              error.description = "Unknown error";
              error.title = "Unknown error";
            }
          }

          return error;
        });
      })
    );
  };
}
