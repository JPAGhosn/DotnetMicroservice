import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LikeDislikeButtonsComponent } from './like-dislike-buttons.component';

describe('LikeDislikeButtonsComponent', () => {
  let component: LikeDislikeButtonsComponent;
  let fixture: ComponentFixture<LikeDislikeButtonsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LikeDislikeButtonsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LikeDislikeButtonsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
