import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ForgotPasswordRedirectComponent } from './forgot-password-redirect.component';

describe('ForgotPasswordRedirectComponent', () => {
  let component: ForgotPasswordRedirectComponent;
  let fixture: ComponentFixture<ForgotPasswordRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ForgotPasswordRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ForgotPasswordRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
