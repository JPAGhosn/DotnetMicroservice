import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeeLaterIconComponent } from './see-later-icon.component';

describe('SeeLaterIconComponent', () => {
  let component: SeeLaterIconComponent;
  let fixture: ComponentFixture<SeeLaterIconComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SeeLaterIconComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SeeLaterIconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
