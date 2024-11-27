import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipeToCollectionsModalComponent } from './recipe-to-collections-modal.component';

describe('RecipeToCollectionsModalComponent', () => {
  let component: RecipeToCollectionsModalComponent;
  let fixture: ComponentFixture<RecipeToCollectionsModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipeToCollectionsModalComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipeToCollectionsModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
