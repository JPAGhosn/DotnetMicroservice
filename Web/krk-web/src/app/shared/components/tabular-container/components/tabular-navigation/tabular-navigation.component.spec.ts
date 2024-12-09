import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabularNavigationComponent } from './tabular-navigation.component';

describe('TabularNavigationComponent', () => {
  let component: TabularNavigationComponent;
  let fixture: ComponentFixture<TabularNavigationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TabularNavigationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabularNavigationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
