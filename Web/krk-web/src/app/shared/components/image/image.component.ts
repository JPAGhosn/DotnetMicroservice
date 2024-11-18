import {Component, EventEmitter, HostBinding, Input, Output, signal, TemplateRef} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {ImageLoaderComponent} from '@shared/components/image/components/image-loader/image-loader.component';

@Component({
  selector: 'krk-image',
  standalone: true,
  imports: [
    NgOptimizedImage,
    ImageLoaderComponent
  ],
  templateUrl: './image.component.html',
  styleUrl: './image.component.scss'
})
export class ImageComponent {
  @Input({required: true}) image?: string;

  @Input() alt: string = "";
  @Input() width: number = 16;
  @Input() height: number = 16;

  @Input() errorTemplate?: TemplateRef<any>;

  @Output("error") onErrorEventEmitter = new EventEmitter<boolean>();

  state = signal<"loading" | "error" | "loaded">("loading");

  @HostBinding('style.height.px') hostHeight!: number;

  onError() {
    this.onErrorEventEmitter.next(true);
    this.adjustClientHeight();
    this.state.set("error")
  }

  onLoaded() {
    this.state.set("loaded")
  }

  adjustClientHeight() {
    if (this.height) {
      this.hostHeight = this.height
    }
  }
}
