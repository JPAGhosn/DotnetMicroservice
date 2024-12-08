import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageSuggestionsComponent } from './recipe-page-suggestions.component';

describe('RecipePageSuggestionsComponent', () => {
  let component: RecipePageSuggestionsComponent;
  let fixture: ComponentFixture<RecipePageSuggestionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageSuggestionsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageSuggestionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
