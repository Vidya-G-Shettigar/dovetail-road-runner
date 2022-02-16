import { Component, OnInit } from '@angular/core';
import { Constants } from '../../../enum/constants';
@Component({
  selector: 'app-app-button',
  templateUrl: './app-button.component.html',
  styleUrls: ['./app-button.component.css'],
})
export class AppButtonComponent implements OnInit {
  /** Variable for pre-defined value */
  public constants: any = Constants;
  constructor() {}

  ngOnInit(): void {}
}
