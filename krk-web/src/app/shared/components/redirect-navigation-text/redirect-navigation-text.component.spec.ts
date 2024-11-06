import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedirectNavigationTextComponent } from './redirect-navigation-text.component';

describe('RedirectNavigationTextComponent', () => {
  let component: RedirectNavigationTextComponent;
  let fixture: ComponentFixture<RedirectNavigationTextComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RedirectNavigationTextComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RedirectNavigationTextComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
