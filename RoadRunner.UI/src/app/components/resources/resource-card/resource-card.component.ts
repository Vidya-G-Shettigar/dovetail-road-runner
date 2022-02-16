import { Component, OnInit } from '@angular/core';
import resourceData from '../../../../assets/road-runner/content/resources.json';
@Component({
  selector: 'app-resource-card',
  templateUrl: './resource-card.component.html',
  styleUrls: ['./resource-card.component.css'],
})
export class ResourceCardComponent implements OnInit {
  card: any;
  constructor() {
    this.card = resourceData;
  }

  ngOnInit(): void {}
}
