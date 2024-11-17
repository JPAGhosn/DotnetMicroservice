import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DevelopersRedirectComponent } from './developers-redirect.component';

describe('DevelopersRedirectComponent', () => {
  let component: DevelopersRedirectComponent;
  let fixture: ComponentFixture<DevelopersRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DevelopersRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DevelopersRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
