import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagsListSkeletonComponent } from './tags-list-skeleton.component';

describe('TagsListSkeletonComponent', () => {
  let component: TagsListSkeletonComponent;
  let fixture: ComponentFixture<TagsListSkeletonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TagsListSkeletonComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TagsListSkeletonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
