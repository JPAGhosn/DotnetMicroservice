import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StartCookingButtonComponent } from './start-cooking-button.component';

describe('StartCookingButtonComponent', () => {
  let component: StartCookingButtonComponent;
  let fixture: ComponentFixture<StartCookingButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StartCookingButtonComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StartCookingButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
