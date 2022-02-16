import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuotestableComponent } from './quotestable.component';

describe('QuotestableComponent', () => {
  let component: QuotestableComponent;
  let fixture: ComponentFixture<QuotestableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuotestableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuotestableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
