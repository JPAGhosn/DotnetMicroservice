import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageUsedByComponent } from './recipe-page-used-by.component';

describe('RecipePageUsedByComponent', () => {
  let component: RecipePageUsedByComponent;
  let fixture: ComponentFixture<RecipePageUsedByComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageUsedByComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageUsedByComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
