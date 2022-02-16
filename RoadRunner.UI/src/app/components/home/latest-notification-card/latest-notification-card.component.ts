import { Component, OnInit } from '@angular/core';
import Latestquote from '../../../../assets/road-runner/content/dashboard.json';
@Component({
  selector: 'app-latest-notification-card',
  templateUrl: './latest-notification-card.component.html',
  styleUrls: ['./latest-notification-card.component.css'],
})
export class LatestNotificationCardComponent implements OnInit {
  cards: any;
  constructor() {
    this.cards = Latestquote;
  }

  ngOnInit(): void {}
}
