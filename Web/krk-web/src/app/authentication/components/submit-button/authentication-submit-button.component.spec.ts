import {ComponentFixture, TestBed} from '@angular/core/testing';

import {AuthenticationSubmitButtonComponent} from './authentication-submit-button.component';

describe('SubmitButtonComponent', () => {
  let component: AuthenticationSubmitButtonComponent;
  let fixture: ComponentFixture<AuthenticationSubmitButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AuthenticationSubmitButtonComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(AuthenticationSubmitButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
