import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageInformationComponent } from './recipe-page-information.component';

describe('RecipePageInformationComponent', () => {
  let component: RecipePageInformationComponent;
  let fixture: ComponentFixture<RecipePageInformationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageInformationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
