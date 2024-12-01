import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectionToAddComponent } from './collection-to-add.component';

describe('CollectionToAddComponent', () => {
  let component: CollectionToAddComponent;
  let fixture: ComponentFixture<CollectionToAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CollectionToAddComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CollectionToAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
