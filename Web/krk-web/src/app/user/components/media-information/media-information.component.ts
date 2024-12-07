import {AfterViewInit, Component, ElementRef, Input, OnDestroy, ViewChild} from '@angular/core';
import {AvatarComponent} from '../avatar/avatar.component';
import {MediaModel} from '../../pages/home-page/models/media.model';
import {DatePipe} from '@angular/common';
import {Subject} from 'rxjs';

@Component({
  selector: 'krk-media-information',
  standalone: true,
  imports: [
    AvatarComponent,
    DatePipe
  ],
  templateUrl: './media-information.component.html',
  styleUrl: './media-information.component.scss'
})
export class MediaInformationComponent implements AfterViewInit, OnDestroy {

  @Input({required: true}) media!: MediaModel;

  @Input({required: true}) minimalInformation1?: string;

  @ViewChild("titleSpan") titleSpan!: ElementRef;

  destroyed$: Subject<void> = new Subject();

  ngAfterViewInit(): void {

  }

  ngOnDestroy() {
    this.destroyed$.next()
  }
}
