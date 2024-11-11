import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BetaAccessRedirectComponent } from './beta-access-redirect.component';

describe('BetaAccessRedirectComponent', () => {
  let component: BetaAccessRedirectComponent;
  let fixture: ComponentFixture<BetaAccessRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BetaAccessRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BetaAccessRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
