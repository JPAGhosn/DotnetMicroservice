import {Component, inject} from '@angular/core';
import {NgTemplateOutlet} from '@angular/common';
import {ModalsService} from '@shared/components/modals/services/modals.service';

@Component({
  selector: 'krk-modals',
  standalone: true,
  imports: [
    NgTemplateOutlet
  ],
  templateUrl: './modals.component.html',
  styleUrl: './modals.component.scss'
})
export class ModalsComponent {
  modalsService = inject(ModalsService)

  onModalOutsideClicked() {
    this.modalsService.hideModal();
  }

  onModalInsideClicked(event: MouseEvent) {
    event.stopPropagation();
  }
}
