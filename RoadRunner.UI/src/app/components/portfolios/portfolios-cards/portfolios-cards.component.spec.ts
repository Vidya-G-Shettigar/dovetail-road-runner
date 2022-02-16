import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PortfoliosCardsComponent } from './portfolios-cards.component';

describe('PortfoliosCardsComponent', () => {
  let component: PortfoliosCardsComponent;
  let fixture: ComponentFixture<PortfoliosCardsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PortfoliosCardsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PortfoliosCardsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
