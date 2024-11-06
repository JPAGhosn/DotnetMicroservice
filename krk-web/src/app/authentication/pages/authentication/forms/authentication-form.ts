import { inject, Injectable } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Injectable()
export class AuthenticationForm {
  fb = inject(FormBuilder);

  formGroup = this.fb.group({
    emailOrPhone: ["", [Validators.required, Validators.email]],
    password: ["", [Validators.required]],
    confirmPassword: ["", [Validators.required]],
  })
}