import { Component, OnInit } from '@angular/core';
import PortfolioData from '../../../../assets/road-runner/content/portfolio.json';

@Component({
  selector: 'app-portfolios-cards',
  templateUrl: './portfolios-cards.component.html',
  styleUrls: ['./portfolios-cards.component.css'],
})
export class PortfoliosCardsComponent implements OnInit {
  card: any;
  constructor() {
    this.card = PortfolioData;
  }

  ngOnInit(): void {
    console.log(this.card);
  }
}
