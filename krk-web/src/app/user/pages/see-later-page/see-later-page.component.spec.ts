import {ComponentFixture, TestBed} from '@angular/core/testing';

import {SeeLaterPageComponent} from './see-later-page.component';

describe('SeeLaterComponent', () => {
  let component: SeeLaterPageComponent;
  let fixture: ComponentFixture<SeeLaterPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SeeLaterPageComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(SeeLaterPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
