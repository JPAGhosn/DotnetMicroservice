import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageTagsComponent } from './recipe-page-tags.component';

describe('RecipePageTagsComponent', () => {
  let component: RecipePageTagsComponent;
  let fixture: ComponentFixture<RecipePageTagsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageTagsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageTagsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
