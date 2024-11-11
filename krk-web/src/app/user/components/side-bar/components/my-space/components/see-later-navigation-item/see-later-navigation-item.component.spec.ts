import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeeLaterNavigationItemComponent } from './see-later-navigation-item.component';

describe('SeeLaterNavigationItemComponent', () => {
  let component: SeeLaterNavigationItemComponent;
  let fixture: ComponentFixture<SeeLaterNavigationItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SeeLaterNavigationItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SeeLaterNavigationItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
