import { Component, OnInit } from '@angular/core';
import dashboard from '../../../../assets/road-runner/content/dashboard.json';

@Component({
  selector: 'app-dashbord',
  templateUrl: './dashbord.component.html',
  styleUrls: ['./dashbord.component.css'],
})
export class DashbordComponent implements OnInit {
  DashboardData: any;
  constructor() {
    this.DashboardData = dashboard;
  }

  ngOnInit(): void {}
}
