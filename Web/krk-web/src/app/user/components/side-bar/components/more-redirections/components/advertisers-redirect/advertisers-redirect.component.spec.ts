import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdvertisersRedirectComponent } from './advertisers-redirect.component';

describe('AdvertisersRedirectComponent', () => {
  let component: AdvertisersRedirectComponent;
  let fixture: ComponentFixture<AdvertisersRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdvertisersRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdvertisersRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
