import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrivacyLayoutComponent } from './privacy-layout.component';

describe('PrivacyLayoutComponent', () => {
  let component: PrivacyLayoutComponent;
  let fixture: ComponentFixture<PrivacyLayoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PrivacyLayoutComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PrivacyLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
