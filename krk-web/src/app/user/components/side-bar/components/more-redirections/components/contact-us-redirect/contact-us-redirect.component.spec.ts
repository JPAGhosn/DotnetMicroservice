import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactUsRedirectComponent } from './contact-us-redirect.component';

describe('ContactUsRedirectComponent', () => {
  let component: ContactUsRedirectComponent;
  let fixture: ComponentFixture<ContactUsRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ContactUsRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContactUsRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
