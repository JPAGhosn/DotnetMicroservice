import {computed, Signal, signal, WritableSignal} from '@angular/core';
import {BaseModel} from '@shared/models/base/base.model';

export abstract class BaseDataStore<T extends BaseModel> {
  private cachedData: WritableSignal<T[]> = signal([]);

  public data: Signal<T[]> = computed(() => {
    return this.cachedData();
  });

  addOne(model: T) {
    const data = [...this.cachedData()];

    const foundIndex = data.findIndex(m => m.id === model.id);

    if (foundIndex !== -1) {
      data.splice(foundIndex, 1);
    }

    data.push(model);

    this.cachedData.set(data);
  }

  addMany(models: T[]) {
    for (const model of models) {
      this.addOne(model);
    }
  }

  removeOne(model: T) {
    const data = [...this.cachedData()];
    const index = data.findIndex(m => m.id === model.id);

    if (index === -1) {
      return
    }

    data.splice(index, 1);

    this.cachedData.set(data);
  }

  removeOneById(id: string) {
    const data = [...this.cachedData()];
    const index = data.findIndex(m => m.id === id);
    if (index === -1) {
      return;
    }
    data.splice(index, 1);
    this.cachedData.set(data);
  }

  findById(id: string): T | null {
    const data = this.data();
    return data.find(m => m.id === id) ?? null;
  }
}
