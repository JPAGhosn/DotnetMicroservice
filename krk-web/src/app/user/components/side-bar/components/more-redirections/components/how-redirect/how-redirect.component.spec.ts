import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HowRedirectComponent } from './how-redirect.component';

describe('HowRedirectComponent', () => {
  let component: HowRedirectComponent;
  let fixture: ComponentFixture<HowRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HowRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HowRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
