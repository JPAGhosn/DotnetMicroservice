import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedirectSimpleTextComponent } from './redirect-simple-text.component';

describe('RedirectSimpleTextComponent', () => {
  let component: RedirectSimpleTextComponent;
  let fixture: ComponentFixture<RedirectSimpleTextComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RedirectSimpleTextComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RedirectSimpleTextComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
