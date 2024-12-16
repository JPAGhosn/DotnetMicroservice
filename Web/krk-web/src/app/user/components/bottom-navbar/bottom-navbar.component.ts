import {Component} from '@angular/core';
import {NavbarItemComponent} from './components/navbar-item/navbar-item.component';
import {RouterLink, RouterLinkActive} from '@angular/router';

@Component({
  selector: 'krk-bottom-navbar',
  standalone: true,
  imports: [
    NavbarItemComponent,
    RouterLink,
    RouterLinkActive
  ],
  templateUrl: './bottom-navbar.component.html',
  styleUrl: './bottom-navbar.component.scss'
})
export class BottomNavbarComponent {

}
