import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-recent-activity',
  templateUrl: './recent-activity.component.html',
  styleUrls: ['./recent-activity.component.css'],
})
export class RecentActivityComponent implements OnInit {
  url: String = '/portfolio/quotes';
  text: String = 'SEE ALL PENDING QUOTES';
  constructor() {}

  ngOnInit(): void {}

  Quotesclick() {
    this.url = '/portfolio/quotes';
    this.text = 'SEE ALL PENDING QUOTES';
  }

  Policyclick() {
    this.url = '/portfolio/policies';
    this.text = 'VIEW ALL POLICIES';
  }
}
