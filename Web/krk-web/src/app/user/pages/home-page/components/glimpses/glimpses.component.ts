import {Component, CUSTOM_ELEMENTS_SCHEMA, inject} from '@angular/core';
import {GlimpseComponent} from './components/glimpse/glimpse.component';
import {GlimpsesStore} from '../../../../stores/glimpses.store';
import {HomeTagComponent} from '../home-tag/home-tag.component';
import {SwiperDirective} from '@shared/directives/swiper.directive';
import {SwiperProps} from 'swiper/react';
import {TitledContainerComponent} from '../titled-container/titled-container.component';
import {HomeService} from '../../services/home.service';

@Component({
  selector: 'krk-glimpses',
  standalone: true,
  imports: [
    GlimpseComponent,
    HomeTagComponent,
    SwiperDirective,
    TitledContainerComponent
  ],
  templateUrl: './glimpses.component.html',
  styleUrl: './glimpses.component.scss',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class GlimpsesComponent {
  glimpsesStore = inject(GlimpsesStore);
  homeService = inject(HomeService)

  swiperConfig: SwiperProps = {
    slidesPerView: "auto",
    spaceBetween: 15,
    slidesOffsetBefore: 30,
    slidesOffsetAfter: 20,
  }
}
