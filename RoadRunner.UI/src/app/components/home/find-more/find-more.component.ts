import { Component, OnInit, Input } from '@angular/core';
import findMoreCard from '../../../../assets/road-runner/content/findmore.json';
import { Carousel } from 'primeng/carousel';
@Component({
  selector: 'app-find-more',
  templateUrl: './find-more.component.html',
  styleUrls: ['./find-more.component.css'],
})
export class FindMoreComponent implements OnInit {
  // @Input() FindmoreData?: any;
  FindmoreData: any;

  responsiveOptions;

  constructor() {
    Carousel.prototype.changePageOnTouch = () => {
      // this is intentional
    };
    this.FindmoreData = findMoreCard;
    this.responsiveOptions = [
      {
        breakpoint: '1024px',
        numVisible: 3,
        numScroll: 3,
      },
      {
        breakpoint: '768px',
        numVisible: 2,
        numScroll: 2,
      },
      {
        breakpoint: '560px',
        numVisible: 1,
        numScroll: 1,
      },
    ];
  }

  ngOnInit() {
    // this.productService.getProductsSmall().then((products) => {
    //   this.products = products;
    // });
    console.log(this.FindmoreData);
  }

  onClick(routeName: string) {
    window.open(routeName, '_blank');
  }
}
