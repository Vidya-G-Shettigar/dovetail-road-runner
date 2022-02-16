import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuickSummaryCardComponent } from './quick-summary-card.component';

describe('QuickSummaryCardComponent', () => {
  let component: QuickSummaryCardComponent;
  let fixture: ComponentFixture<QuickSummaryCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuickSummaryCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuickSummaryCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
