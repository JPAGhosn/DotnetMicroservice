import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TitledContainerComponent } from './titled-container.component';

describe('TitledContainerComponent', () => {
  let component: TitledContainerComponent;
  let fixture: ComponentFixture<TitledContainerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TitledContainerComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TitledContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
