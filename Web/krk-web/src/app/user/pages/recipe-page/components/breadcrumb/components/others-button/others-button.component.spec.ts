import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OthersButtonComponent } from './others-button.component';

describe('OthersButtonComponent', () => {
  let component: OthersButtonComponent;
  let fixture: ComponentFixture<OthersButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [OthersButtonComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OthersButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
