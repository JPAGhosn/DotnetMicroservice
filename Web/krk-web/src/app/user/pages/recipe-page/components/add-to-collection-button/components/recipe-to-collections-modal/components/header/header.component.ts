import {Component} from '@angular/core';
import {IconButtonComponent} from "../../../../../../../../components/icon-button/icon-button.component";
import {SearchBarComponent} from "../../../../../../../../components/search-bar/search-bar.component";

@Component({
  selector: 'krk-header',
  standalone: true,
  imports: [
    IconButtonComponent,
    SearchBarComponent
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {

}
