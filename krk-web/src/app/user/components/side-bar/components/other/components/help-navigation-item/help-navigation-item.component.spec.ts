import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelpNavigationItemComponent } from './help-navigation-item.component';

describe('HelpNavigationItemComponent', () => {
  let component: HelpNavigationItemComponent;
  let fixture: ComponentFixture<HelpNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HelpNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HelpNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
