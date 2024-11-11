import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectionsIconComponent } from './collections-icon.component';

describe('CollectionsIconComponent', () => {
  let component: CollectionsIconComponent;
  let fixture: ComponentFixture<CollectionsIconComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CollectionsIconComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CollectionsIconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
