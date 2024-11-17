import {Injectable, signal, WritableSignal} from '@angular/core';

@Injectable()
export class LoaderService {
  loaders: WritableSignal<string[]> = signal([])

  show(id: string) {
    const loaders = this.loaders();
    loaders.push(id);
    this.loaders.set(loaders)
  }

  hide(id: string) {
    let loaders = this.loaders()
    loaders = loaders.filter(loaderId => loaderId !== id);
    this.loaders.set(loaders)
  }
}
