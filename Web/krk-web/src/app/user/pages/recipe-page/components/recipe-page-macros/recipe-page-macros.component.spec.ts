import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageMacrosComponent } from './recipe-page-macros.component';

describe('RecipePageMacrosComponent', () => {
  let component: RecipePageMacrosComponent;
  let fixture: ComponentFixture<RecipePageMacrosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageMacrosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageMacrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
