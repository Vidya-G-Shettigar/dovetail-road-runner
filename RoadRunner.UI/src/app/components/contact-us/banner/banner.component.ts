import { Component, OnInit } from '@angular/core';
import ContactData from '../../../../assets/road-runner/content/contact-us.json';
@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.css'],
})
export class BannerComponent implements OnInit {
  contact: any;
  constructor() {
    this.contact = ContactData;
  }

  ngOnInit(): void {}
}
