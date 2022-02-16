import { Component, OnInit } from '@angular/core';
import resourceData from '../../../../assets/road-runner/content/resources.json';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.css'],
})
export class BannerComponent implements OnInit {
  card: any;
  constructor() {
    this.card = resourceData;
  }

  ngOnInit(): void {
    console.log(this.card);
  }
}
