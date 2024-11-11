import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MySpaceIconComponent } from './my-space-icon.component';

describe('MySpaceIconComponent', () => {
  let component: MySpaceIconComponent;
  let fixture: ComponentFixture<MySpaceIconComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MySpaceIconComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MySpaceIconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
