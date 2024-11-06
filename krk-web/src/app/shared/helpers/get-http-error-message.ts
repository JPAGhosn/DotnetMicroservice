import {HttpErrorResponse} from '@angular/common/http';

export function getHttpErrorMessage(error: any) {
  if (error instanceof HttpErrorResponse) {
    if (error.status === 0) {
      return 'A network error occurred. Please check your internet connection.';
    } else {
      return `HTTP Error ${error.status}: ${error.message}`;
    }
  }
  else if (
    error &&
    typeof error === 'object' &&
    typeof error.code === 'string' &&
    typeof error.message === 'string'
  ) {
    return error.message;
  }
  else {
    return 'An unexpected error occurred';
  }

}
