import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PolicyConformationComponent } from './policy-conformation.component';

describe('PolicyConformationComponent', () => {
  let component: PolicyConformationComponent;
  let fixture: ComponentFixture<PolicyConformationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PolicyConformationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PolicyConformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
