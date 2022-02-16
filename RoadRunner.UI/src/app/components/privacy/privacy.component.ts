import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import privacypage from '../../../assets/road-runner/content/privacy.json';
@Component({
  encapsulation: ViewEncapsulation.None,
  selector: 'app-privacy',
  templateUrl: './privacy.component.html',
  styleUrls: ['./privacy.component.css'],
})
export class PrivacyComponent implements OnInit {
  privacy: any;
  constructor() {
    this.privacy = privacypage;
  }

  ngOnInit(): void {}
}
