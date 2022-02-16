import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import PortfolioData from '../../../../assets/road-runner/content/portfolio.json';
@Component({
  // encapsulation: ViewEncapsulation.None,
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.css'],
})
export class BannerComponent implements OnInit {
  card: any;
  constructor() {
    this.card = PortfolioData;
  }

  ngOnInit() {
    console.log(this.card);
  }
}
