import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageCoverComponent } from './recipe-page-cover.component';

describe('RecipePageCoverComponent', () => {
  let component: RecipePageCoverComponent;
  let fixture: ComponentFixture<RecipePageCoverComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageCoverComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageCoverComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
