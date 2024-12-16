import {Component, CUSTOM_ELEMENTS_SCHEMA, inject} from '@angular/core';
import {TagComponent} from '@shared/components/tag/tag.component';
import {SwiperDirective} from '@shared/directives/swiper.directive';
import {TagsStore} from '../../../../stores/tags.store';
import {HomeTagComponent} from '../home-tag/home-tag.component';
import {SwiperProps} from 'swiper/react';

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
  tagsStore = inject(TagsStore);

  swiperConfig: SwiperProps = {
    slidesPerView: "auto",
    spaceBetween: 10,
    breakpoints: {
      0: {
        slidesOffsetBefore: 11,
        slidesOffsetAfter: 11,
      },
      768: {
        slidesOffsetBefore: 30,
        slidesOffsetAfter: 30,
      }
    }
  }

}
