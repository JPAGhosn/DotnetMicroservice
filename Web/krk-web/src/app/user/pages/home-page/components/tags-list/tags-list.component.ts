import {Component, CUSTOM_ELEMENTS_SCHEMA, inject} from '@angular/core';
import {SwiperProps} from 'swiper/react';
import {TagComponent} from '@shared/components/tag/tag.component';
import {SwiperDirective} from '@shared/directives/swiper.directive';
import {TagsStore} from '../../../../stores/tags.store';
import {HomeService} from '../../services/home.service';
import {HomeTagComponent} from '../home-tag/home-tag.component';

@Component({
  selector: 'krk-tags-list',
  standalone: true,
  imports: [
    TagComponent,
    SwiperDirective,
    HomeTagComponent
  ],
  templateUrl: './tags-list.component.html',
  styleUrl: './tags-list.component.scss',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class TagsListComponent {
  homeService = inject(HomeService)

  tagsStore = inject(TagsStore);

  swiperConfig: SwiperProps = {
    slidesPerView: "auto",
    spaceBetween: 10,
    slidesOffsetBefore: 30,
    slidesOffsetAfter: 30,
  }
}
