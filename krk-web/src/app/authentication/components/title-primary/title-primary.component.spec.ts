import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TitlePrimaryComponent } from './title-primary.component';

describe('TitlePrimaryComponent', () => {
  let component: TitlePrimaryComponent;
  let fixture: ComponentFixture<TitlePrimaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TitlePrimaryComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TitlePrimaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
