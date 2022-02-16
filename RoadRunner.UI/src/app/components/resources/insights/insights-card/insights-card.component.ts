import { Component, OnInit } from '@angular/core';
import resourceData from '../../../../../assets/road-runner/content/insights.json';

@Component({
  selector: 'app-insights-card',
  templateUrl: './insights-card.component.html',
  styleUrls: ['./insights-card.component.css'],
})
export class InsightsCardComponent implements OnInit {
  insights: any;
  constructor() {
    this.insights = resourceData;
  }

  ngOnInit(): void {
    console.log(this.insights);
  }

  onClick(routeName: string) {
    window.open(routeName, '_blank');
  }
}
