import { Component, OnInit } from '@angular/core';
import { Carousel } from 'primeng/carousel';
import findMoreCard from '../../../../assets/road-runner/content/findmore.json';
@Component({
  selector: 'app-card-tile',
  templateUrl: './card-tile.component.html',
  styleUrls: ['./card-tile.component.css'],
})
export class CardTileComponent implements OnInit {
  FindmoreData: any;

  constructor() {
    this.FindmoreData = findMoreCard;
    Carousel.prototype.changePageOnTouch = () => {
      // this is intentional
    };
  }

  ngOnInit(): void {
    console.log(this.FindmoreData);
  }
}
