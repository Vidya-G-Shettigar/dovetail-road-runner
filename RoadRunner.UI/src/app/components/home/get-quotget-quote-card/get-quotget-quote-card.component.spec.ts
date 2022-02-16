import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetQuotgetQuoteCardComponent } from './get-quotget-quote-card.component';

describe('GetQuotgetQuoteCardComponent', () => {
  let component: GetQuotgetQuoteCardComponent;
  let fixture: ComponentFixture<GetQuotgetQuoteCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetQuotgetQuoteCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetQuotgetQuoteCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
