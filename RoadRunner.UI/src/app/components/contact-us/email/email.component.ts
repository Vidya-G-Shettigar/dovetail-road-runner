import { Component, OnInit } from '@angular/core';
import ContactData from '../../../../assets/road-runner/content/contact-us.json';

@Component({
  selector: 'app-email',
  templateUrl: './email.component.html',
  styleUrls: ['./email.component.css'],
})
export class EmailComponent implements OnInit {
  card: any;
  constructor() {
    this.card = ContactData;
  }

  ngOnInit(): void {}
}
