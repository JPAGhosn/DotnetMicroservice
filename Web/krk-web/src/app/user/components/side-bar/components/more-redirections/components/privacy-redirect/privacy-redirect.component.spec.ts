import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrivacyRedirectComponent } from './privacy-redirect.component';

describe('PrivacyRedirectComponent', () => {
  let component: PrivacyRedirectComponent;
  let fixture: ComponentFixture<PrivacyRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PrivacyRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PrivacyRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
