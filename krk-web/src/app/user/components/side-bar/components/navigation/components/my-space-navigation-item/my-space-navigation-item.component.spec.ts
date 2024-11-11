import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MySpaceNavigationItemComponent } from './my-space-navigation-item.component';

describe('MySpaceNavigationItemComponent', () => {
  let component: MySpaceNavigationItemComponent;
  let fixture: ComponentFixture<MySpaceNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MySpaceNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MySpaceNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
