import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PressRedirectComponent } from './press-redirect.component';

describe('PressRedirectComponent', () => {
  let component: PressRedirectComponent;
  let fixture: ComponentFixture<PressRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PressRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PressRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
