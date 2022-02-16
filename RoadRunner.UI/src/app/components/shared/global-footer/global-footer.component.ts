import { Component, OnInit } from '@angular/core';
import desktopMenu from '../../../../assets/road-runner/content/footer.json';
@Component({
  selector: 'app-global-footer',
  templateUrl: './global-footer.component.html',
  styleUrls: ['./global-footer.component.css'],
})
export class GlobalFooterComponent implements OnInit {
  FooterData: any;
  constructor() {
    this.FooterData = desktopMenu;
  }

  ngOnInit(): void {}
}
