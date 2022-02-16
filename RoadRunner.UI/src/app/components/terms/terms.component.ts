import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import termsandcondition from '../../../assets/road-runner/content/terms.json';

@Component({
  encapsulation: ViewEncapsulation.None,
  selector: 'app-terms',
  templateUrl: './terms.component.html',
  styleUrls: ['./terms.component.css'],
})
export class TermsComponent implements OnInit {
  terms: any;
  constructor() {
    this.terms = termsandcondition;
  }

  ngOnInit(): void {}
}
