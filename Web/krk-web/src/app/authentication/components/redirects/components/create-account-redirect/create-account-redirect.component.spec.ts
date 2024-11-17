import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateAccountRedirectComponent } from './create-account-redirect.component';

describe('CreateAccountRedirectComponent', () => {
  let component: CreateAccountRedirectComponent;
  let fixture: ComponentFixture<CreateAccountRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateAccountRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateAccountRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
