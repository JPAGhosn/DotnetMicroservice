import {Directive, ElementRef, Input} from '@angular/core';
import {SwiperContainer} from 'swiper/element';
import {SwiperOptions} from 'swiper/types';

@Directive({
  selector: '[krkSwiper]',
  standalone: true,
})
export class SwiperDirective {
  @Input() config?: SwiperOptions;

  constructor(private el: ElementRef<SwiperContainer>) {
  }

  ngAfterViewInit(): void {
    Object.assign(this.el.nativeElement, this.config);

    this.el.nativeElement.initialize();
  }
}
