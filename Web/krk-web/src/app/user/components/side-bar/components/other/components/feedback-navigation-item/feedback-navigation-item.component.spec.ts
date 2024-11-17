import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeedbackNavigationItemComponent } from './feedback-navigation-item.component';

describe('FeedbackNavigationItemComponent', () => {
  let component: FeedbackNavigationItemComponent;
  let fixture: ComponentFixture<FeedbackNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FeedbackNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FeedbackNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
