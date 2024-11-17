import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiscoverIconComponent } from './discover-icon.component';

describe('DiscoverIconComponent', () => {
  let component: DiscoverIconComponent;
  let fixture: ComponentFixture<DiscoverIconComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DiscoverIconComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DiscoverIconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
