import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PiracyRedirectComponent } from './piracy-redirect.component';

describe('PiracyRedirectComponent', () => {
  let component: PiracyRedirectComponent;
  let fixture: ComponentFixture<PiracyRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PiracyRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PiracyRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
