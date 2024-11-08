import { Component } from '@angular/core';
import {TopBarComponent} from './components/top-bar/top-bar.component';
import {SideBarComponent} from './components/side-bar/side-bar.component';
import {RouterOutlet} from '@angular/router';

@Component({
  selector: 'krk-user',
  standalone: true,
  imports: [
    TopBarComponent,
    SideBarComponent,
    RouterOutlet
  ],
  templateUrl: './user.component.html',
  styleUrl: './user.component.scss'
})
export class UserComponent {

}
