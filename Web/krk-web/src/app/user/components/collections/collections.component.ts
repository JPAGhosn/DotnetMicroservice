import {Component, CUSTOM_ELEMENTS_SCHEMA, inject} from '@angular/core';
import {TitledContainerComponent} from '../../pages/home-page/components/titled-container/titled-container.component';
import {GlimpseComponent} from '../../pages/home-page/components/glimpses/components/glimpse/glimpse.component';
import {SwiperDirective} from '@shared/directives/swiper.directive';
import {SwiperProps} from 'swiper/react';
import {CollectionComponent} from '../collection/collection.component';
import {CollectionsStore} from '../../stores/collections.store';
import {HomeService} from '../../pages/home-page/services/home.service';

@Component({
  selector: 'krk-collections',
  standalone: true,
  imports: [
    TitledContainerComponent,
    GlimpseComponent,
    SwiperDirective,
    CollectionComponent
  ],
  templateUrl: './collections.component.html',
  styleUrl: './collections.component.scss',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class CollectionsComponent {
  homeService = inject(HomeService)
  collectionsStore = inject(CollectionsStore);

  swiperConfig: SwiperProps = {
    slidesPerView: "auto",
    spaceBetween: 15,
    slidesOffsetBefore: 30,
    slidesOffsetAfter: 20,
  }
}
