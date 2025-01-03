import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeedbackIconComponent } from './feedback-icon.component';

describe('FeedbackIconComponent', () => {
  let component: FeedbackIconComponent;
  let fixture: ComponentFixture<FeedbackIconComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FeedbackIconComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FeedbackIconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
