import {Component, EventEmitter, HostBinding, Input, OnInit, Output, signal, TemplateRef} from '@angular/core';
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
export class ImageComponent implements OnInit {
  @Input({required: true}) image?: string;

  @Input() alt: string = "";
  @Input() width: number = 16;
  @Input() height: number = 16;

  @Input() errorTemplate?: TemplateRef<any>;

  @Output("error") onErrorEventEmitter = new EventEmitter<boolean>();

  state = signal<"loading" | "error" | "loaded">("loading");

  @HostBinding('style.height.px') hostHeight!: number;

  ngOnInit() {

    // If image is null or empty show error no image placeholder
    if (!this.image) {
      this.state.set("error")
    }
  }

  // Handling image load error
  onError() {
    this.onErrorEventEmitter.next(true);
    // this.adjustClientHeight();
    this.state.set("error")
  }

  // Remove loader and show image
  onLoaded() {
    this.state.set("loaded")
  }


  adjustClientHeight() {
    if (this.height) {
      this.hostHeight = this.height
    }
  }
}
