import {Injector} from '@angular/core';
import {finalize, Observable} from 'rxjs';
import {LoaderService} from '@shared/services/loader.service';

export function hideLoader<T>(injector: Injector, id: string) {
  return (source: Observable<T>) => {
    const loaderService = injector.get(LoaderService);

    return source.pipe(
      finalize(() => {
        loaderService.hide(id);
      })
    );
  };
}
