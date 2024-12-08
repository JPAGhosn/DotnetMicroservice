import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageTabularDescriptionsComponent } from './recipe-page-tabular-descriptions.component';

describe('RecipePageTabularDescriptionsComponent', () => {
  let component: RecipePageTabularDescriptionsComponent;
  let fixture: ComponentFixture<RecipePageTabularDescriptionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageTabularDescriptionsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageTabularDescriptionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
