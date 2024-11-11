import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CopyrightRedirectComponent } from './copyright-redirect.component';

describe('CopyrightRedirectComponent', () => {
  let component: CopyrightRedirectComponent;
  let fixture: ComponentFixture<CopyrightRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CopyrightRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CopyrightRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
