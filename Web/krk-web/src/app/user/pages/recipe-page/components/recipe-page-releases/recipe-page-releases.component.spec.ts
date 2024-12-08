import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipePageReleasesComponent } from './recipe-page-releases.component';

describe('RecipePageReleasesComponent', () => {
  let component: RecipePageReleasesComponent;
  let fixture: ComponentFixture<RecipePageReleasesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipePageReleasesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipePageReleasesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
