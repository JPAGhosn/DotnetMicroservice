import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectionCoverComponent } from './collection-cover.component';

describe('CollectionCoverComponent', () => {
  let component: CollectionCoverComponent;
  let fixture: ComponentFixture<CollectionCoverComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CollectionCoverComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CollectionCoverComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
