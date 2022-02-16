import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppetiteChecksComponent } from './appetite-checks.component';

describe('AppetiteChecksComponent', () => {
  let component: AppetiteChecksComponent;
  let fixture: ComponentFixture<AppetiteChecksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppetiteChecksComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppetiteChecksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
