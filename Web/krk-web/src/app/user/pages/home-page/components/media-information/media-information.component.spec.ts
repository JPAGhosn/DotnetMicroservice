import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MediaInformationComponent } from './media-information.component';

describe('MediaInformationComponent', () => {
  let component: MediaInformationComponent;
  let fixture: ComponentFixture<MediaInformationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MediaInformationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MediaInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
