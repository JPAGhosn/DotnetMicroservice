import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConnectNavigationItemComponent } from './connect-navigation-item.component';

describe('ConnectNavigationItemComponent', () => {
  let component: ConnectNavigationItemComponent;
  let fixture: ComponentFixture<ConnectNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConnectNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConnectNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
