import {Injectable, signal} from '@angular/core';
import {BaseError} from '@shared/models/base/base-error';

@Injectable()
export class SnackbarService {
  title = signal("");
  message = signal("");
  type = signal<"" | "error" | "success">("");

  showError(error: BaseError) {
    this.type = signal("error");
    this.title.set(error.title ?? "Unknown error")
    this.message.set(error.description ?? "")
  }

  hide() {
    this.type = signal("");
    this.message = signal("");
  }
}
