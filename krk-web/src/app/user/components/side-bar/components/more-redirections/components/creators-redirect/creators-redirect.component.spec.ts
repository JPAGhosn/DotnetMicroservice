import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatorsRedirectComponent } from './creators-redirect.component';

describe('CreatorsRedirectComponent', () => {
  let component: CreatorsRedirectComponent;
  let fixture: ComponentFixture<CreatorsRedirectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreatorsRedirectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreatorsRedirectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
