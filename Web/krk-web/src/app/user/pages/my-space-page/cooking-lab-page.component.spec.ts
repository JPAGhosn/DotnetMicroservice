import {ComponentFixture, TestBed} from '@angular/core/testing';

import {CookingLabPageComponent} from './cooking-lab-page.component';

describe('MySpacePageComponent', () => {
  let component: CookingLabPageComponent;
  let fixture: ComponentFixture<CookingLabPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CookingLabPageComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(CookingLabPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
