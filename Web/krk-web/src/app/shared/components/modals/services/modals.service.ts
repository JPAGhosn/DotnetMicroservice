import {Injectable, signal, TemplateRef} from '@angular/core';

@Injectable()
export class ModalsService {
  modalTemplate = signal<TemplateRef<any> | null>(null);

  showModal(template: TemplateRef<any>) {
    this.modalTemplate.set(template);
  }

  hideModal() {
    this.modalTemplate.set(null);
  }
}
