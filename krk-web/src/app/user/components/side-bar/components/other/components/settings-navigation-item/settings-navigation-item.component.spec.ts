import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SettingsNavigationItemComponent } from './settings-navigation-item.component';

describe('SettingsNavigationItemComponent', () => {
  let component: SettingsNavigationItemComponent;
  let fixture: ComponentFixture<SettingsNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SettingsNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SettingsNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
