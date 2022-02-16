import { Component, OnInit } from '@angular/core';
import resourceData from '../../../../assets/road-runner/content/appetite-checks.json';

@Component({
  selector: 'app-appetite-checks',
  templateUrl: './appetite-checks.component.html',
  styleUrls: ['./appetite-checks.component.css'],
})
export class AppetiteChecksComponent implements OnInit {
  card: any;
  constructor() {
    this.card = resourceData;
  }

  ngOnInit(): void {}
}
