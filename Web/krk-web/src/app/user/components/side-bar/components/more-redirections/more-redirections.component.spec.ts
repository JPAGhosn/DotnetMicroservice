import {ComponentFixture, TestBed} from '@angular/core/testing';

import {MoreRedirectionsComponent} from './more-redirections.component';

describe('MoreRedirectionComponent', () => {
  let component: MoreRedirectionsComponent;
  let fixture: ComponentFixture<MoreRedirectionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MoreRedirectionsComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(MoreRedirectionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
