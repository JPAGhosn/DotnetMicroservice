import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageContributorsComponent } from './recipe-page-contributors.component';

describe('RecipePageContributorsComponent', () => {
  let component: RecipePageContributorsComponent;
  let fixture: ComponentFixture<RecipePageContributorsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageContributorsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageContributorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
