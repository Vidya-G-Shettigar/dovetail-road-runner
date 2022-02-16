import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TermsLayoutComponent } from './terms-layout.component';

describe('TermsLayoutComponent', () => {
  let component: TermsLayoutComponent;
  let fixture: ComponentFixture<TermsLayoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TermsLayoutComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TermsLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
