import {ComponentFixture, TestBed} from '@angular/core/testing';

import {IconSubmitButtonComponent} from './icon-submit-button.component';

describe('SubmitButtonComponent', () => {
  let component: IconSubmitButtonComponent;
  let fixture: ComponentFixture<IconSubmitButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [IconSubmitButtonComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(IconSubmitButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
