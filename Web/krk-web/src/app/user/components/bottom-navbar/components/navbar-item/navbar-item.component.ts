import {Component, computed, effect, HostBinding, HostListener, inject, input} from '@angular/core';
import {Router} from '@angular/router';
import {toSignal} from '@angular/core/rxjs-interop';

@Component({
  selector: 'krk-navbar-item',
  standalone: true,
  imports: [],
  templateUrl: './navbar-item.component.html',
  styleUrl: './navbar-item.component.scss'
})
export class NavbarItemComponent {

  navigateTo = input<string>("/");

  router = inject(Router);

  urlEvents = toSignal(this.router.events)

  isSelected = computed(() => {
    this.urlEvents();
    return this.router.isActive(this.navigateTo(), {
      paths: 'subset',
      queryParams: 'ignored',
      matrixParams: 'ignored',
      fragment: 'ignored',
    });
  })

  @HostBinding("class.active") _selected = false;

  constructor() {
    effect(() => {
      this._selected = this.isSelected();
    });
  }

  navigate() {
    this.router.navigate([this.navigateTo()], {
      replaceUrl: true
    });
  }

  @HostListener('click', ['$event'])
  onClick() {
    this.navigate();
  }
}
