import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiscoverNavigationItemComponent } from './discover-navigation-item.component';

describe('DiscoverNavigationItemComponent', () => {
  let component: DiscoverNavigationItemComponent;
  let fixture: ComponentFixture<DiscoverNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DiscoverNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DiscoverNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
