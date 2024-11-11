import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConnectIconComponent } from './connect-icon.component';

describe('ConnectIconComponent', () => {
  let component: ConnectIconComponent;
  let fixture: ComponentFixture<ConnectIconComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConnectIconComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConnectIconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
