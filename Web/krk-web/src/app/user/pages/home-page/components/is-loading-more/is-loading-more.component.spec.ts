import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IsLoadingMoreComponent } from './is-loading-more.component';

describe('IsLoadingMoreComponent', () => {
  let component: IsLoadingMoreComponent;
  let fixture: ComponentFixture<IsLoadingMoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [IsLoadingMoreComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IsLoadingMoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
