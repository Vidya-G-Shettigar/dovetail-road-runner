import { Component, OnInit } from '@angular/core';
import ContactData from '../../../../assets/road-runner/content/contact-us.json';
@Component({
  selector: 'app-phone',
  templateUrl: './phone.component.html',
  styleUrls: ['./phone.component.css'],
})
export class PhoneComponent implements OnInit {
  card: any;
  constructor() {
    this.card = ContactData;
  }

  ngOnInit(): void {}
}
