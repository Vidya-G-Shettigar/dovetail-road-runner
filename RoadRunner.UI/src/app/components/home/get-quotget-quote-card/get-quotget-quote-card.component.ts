import { Component, OnInit } from '@angular/core';
import Getquote from '../../../../assets/road-runner/content/dashboard.json';
@Component({
  selector: 'app-get-quotget-quote-card',
  templateUrl: './get-quotget-quote-card.component.html',
  styleUrls: ['./get-quotget-quote-card.component.css'],
})
export class GetQuotgetQuoteCardComponent implements OnInit {
  cards: any;
  constructor() {
    this.cards = Getquote;
  }

  ngOnInit(): void {
    console.log(this.cards.getQuoteCard);
  }
}
