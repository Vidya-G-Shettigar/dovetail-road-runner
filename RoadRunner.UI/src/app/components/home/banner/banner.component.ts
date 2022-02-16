import { Component, OnInit } from '@angular/core';
import ResourceData from '../../../../assets/road-runner/content/resources.json';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.css'],
})
export class BannerComponent implements OnInit {
  DashboardData: any;
  constructor() {}

  ngOnInit(): void {}
}
