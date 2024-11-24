import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddToCollectionButtonComponent } from './add-to-collection-button.component';

describe('AddToCollectionButtonComponent', () => {
  let component: AddToCollectionButtonComponent;
  let fixture: ComponentFixture<AddToCollectionButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddToCollectionButtonComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddToCollectionButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
