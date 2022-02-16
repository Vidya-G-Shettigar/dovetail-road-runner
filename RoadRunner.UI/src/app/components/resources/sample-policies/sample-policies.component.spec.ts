import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SamplePoliciesComponent } from './sample-policies.component';

describe('SamplePoliciesComponent', () => {
  let component: SamplePoliciesComponent;
  let fixture: ComponentFixture<SamplePoliciesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SamplePoliciesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SamplePoliciesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
