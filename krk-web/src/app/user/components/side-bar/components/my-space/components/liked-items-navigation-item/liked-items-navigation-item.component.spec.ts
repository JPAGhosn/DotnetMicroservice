import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LikedItemsNavigationItemComponent } from './liked-items-navigation-item.component';

describe('LikedItemsNavigationItemComponent', () => {
  let component: LikedItemsNavigationItemComponent;
  let fixture: ComponentFixture<LikedItemsNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LikedItemsNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LikedItemsNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
