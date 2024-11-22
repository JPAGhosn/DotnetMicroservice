import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GlimpsesComponent } from './glimpses.component';

describe('GlimpsesComponent', () => {
  let component: GlimpsesComponent;
  let fixture: ComponentFixture<GlimpsesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GlimpsesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GlimpsesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
