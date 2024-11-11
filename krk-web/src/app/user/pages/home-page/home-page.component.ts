import {Component, inject, OnInit} from '@angular/core';
import {HomeService} from './services/home.service';
import {HomeRemote} from './remotes/home.remote';

@Component({
  selector: 'krk-home-page',
  standalone: true,
  imports: [],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss',
  providers: [
    HomeService,
    HomeRemote
  ]
})
export class HomePageComponent implements OnInit {
  homeService = inject(HomeService);

  ngOnInit() {
    this.homeService.fetch();
  }
}
