import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageExtraInformationComponent } from './recipe-page-extra-information.component';

describe('RecipePageExtraInformationComponent', () => {
  let component: RecipePageExtraInformationComponent;
  let fixture: ComponentFixture<RecipePageExtraInformationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageExtraInformationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageExtraInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
