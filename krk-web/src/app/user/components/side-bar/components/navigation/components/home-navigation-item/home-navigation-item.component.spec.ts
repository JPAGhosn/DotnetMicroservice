import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeNavigationItemComponent } from './home-navigation-item.component';

describe('HomeNavigationItemComponent', () => {
  let component: HomeNavigationItemComponent;
  let fixture: ComponentFixture<HomeNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HomeNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
