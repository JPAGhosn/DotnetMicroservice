import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeTagComponent } from './home-tag.component';

describe('HomeTagComponent', () => {
  let component: HomeTagComponent;
  let fixture: ComponentFixture<HomeTagComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HomeTagComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeTagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
