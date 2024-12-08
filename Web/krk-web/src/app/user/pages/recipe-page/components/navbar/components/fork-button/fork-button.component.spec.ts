import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ForkButtonComponent } from './fork-button.component';

describe('ForkButtonComponent', () => {
  let component: ForkButtonComponent;
  let fixture: ComponentFixture<ForkButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ForkButtonComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ForkButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
