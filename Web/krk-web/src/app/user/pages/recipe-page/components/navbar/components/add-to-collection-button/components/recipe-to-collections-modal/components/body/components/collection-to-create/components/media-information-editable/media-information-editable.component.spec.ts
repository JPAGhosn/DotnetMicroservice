import {ComponentFixture, TestBed} from '@angular/core/testing';

import {MediaInformationEditableComponent} from './media-information-editable.component';

describe('MediaInformationComponent', () => {
  let component: MediaInformationEditableComponent;
  let fixture: ComponentFixture<MediaInformationEditableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MediaInformationEditableComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(MediaInformationEditableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
