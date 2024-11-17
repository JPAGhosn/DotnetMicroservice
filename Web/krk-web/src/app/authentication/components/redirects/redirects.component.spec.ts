import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedirectsComponent } from './redirects.component';

describe('RedirectsComponent', () => {
  let component: RedirectsComponent;
  let fixture: ComponentFixture<RedirectsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RedirectsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RedirectsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
