import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutRedirectComponent } from './about-redirect.component';

describe('AboutRedirectComponent', () => {
  let component: AboutRedirectComponent;
  let fixture: ComponentFixture<AboutRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AboutRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AboutRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
