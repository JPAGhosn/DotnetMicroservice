import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectionsNavigationItemComponent } from './collections-navigation-item.component';

describe('CollectionsNavigationItemComponent', () => {
  let component: CollectionsNavigationItemComponent;
  let fixture: ComponentFixture<CollectionsNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CollectionsNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CollectionsNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
