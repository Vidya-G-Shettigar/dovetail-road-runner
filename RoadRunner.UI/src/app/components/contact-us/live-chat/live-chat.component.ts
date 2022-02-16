import { Component, OnInit } from '@angular/core';
import ContactData from '../../../../assets/road-runner/content/contact-us.json';

@Component({
  selector: 'app-live-chat',
  templateUrl: './live-chat.component.html',
  styleUrls: ['./live-chat.component.css'],
})
export class LiveChatComponent implements OnInit {
  card: any;
  constructor() {
    this.card = ContactData;
  }

  ngOnInit(): void {}
}
