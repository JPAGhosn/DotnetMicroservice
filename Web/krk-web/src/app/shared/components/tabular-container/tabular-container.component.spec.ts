import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabularContainerComponent } from './tabular-container.component';

describe('TabularContainerComponent', () => {
  let component: TabularContainerComponent;
  let fixture: ComponentFixture<TabularContainerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TabularContainerComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabularContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
