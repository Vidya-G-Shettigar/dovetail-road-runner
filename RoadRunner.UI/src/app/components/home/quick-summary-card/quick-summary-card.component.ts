import { Component, OnInit } from '@angular/core';
import Getquote from '../../../../assets/road-runner/content/dashboard.json';
@Component({
  selector: 'app-quick-summary-card',
  templateUrl: './quick-summary-card.component.html',
  styleUrls: ['./quick-summary-card.component.css'],
})
export class QuickSummaryCardComponent implements OnInit {
  cards: any;
  constructor() {
    this.cards = Getquote;
  }

  ngOnInit(): void {}
}
