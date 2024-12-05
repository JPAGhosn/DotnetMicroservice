import {AfterViewInit, Component, ElementRef, Input, OnDestroy, ViewChild} from '@angular/core';
import {AvatarComponent} from '../../../../components/avatar/avatar.component';
import {MediaModel} from '../../models/media.model';
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

  @Input() mode: "read" | "edit" = "read"

  @ViewChild("titleSpan") titleSpan!: ElementRef;

  destroyed$: Subject<void> = new Subject();

  ngAfterViewInit(): void {
    if (this.mode === "edit") {
      this.titleSpan.nativeElement.focus()
    }
  }

  ngOnDestroy() {
    this.destroyed$.next()
  }
}
