import { Component, OnInit } from '@angular/core';
import { elementAt } from 'rxjs-compat/operator/elementAt';
import resourceData from '../../../../assets/road-runner/content/sample-policies-2.json';
@Component({
  selector: 'app-sample-policies',
  templateUrl: './sample-policies.component.html',
  styleUrls: ['./sample-policies.component.css'],
})
export class SamplePoliciesComponent implements OnInit {
  // Entire Sample Json to be stored here
  sample: any;
  // Carriers based on business line will be available here
  carriers = [];
  // documents based on the carriers will be available here
  documents = [];
  // manages the accordion to be selected
  accordionSelectionArray = [];
  // disables all other accordion apart from the selected accordion
  accordionDisabledArray = [];
  // shows the accordion header by default
  // if any value is selected, it is stored here
  accordionHeader = [];
  lastselectedlob;
  lastselectedcarrier;

  constructor() {
    this.sample = resourceData;
    // Enables the first accordion and makes it selected
    // rest are disabled and not selected
    this.sample.samples.forEach((element, index) => {
      if (index == 0) this.accordionSelectionArray.push(true);
      else this.accordionSelectionArray.push(false);
    });

    this.accordionSelectionArray.forEach((element) => {
      this.accordionDisabledArray.push(!element);
    });
  }

  ngOnInit(): void {}

  // Disables Accordion tab collapse and expand
  stopPropagation($event: MouseEvent) {
    $event.stopPropagation();
  }

  // Gets carrier based on business line name
  getCarrier(lobName, index) {
    // empties the carriers and documents
    this.lastselectedlob = index;
    this.lastselectedcarrier = '';
    this.documents = [];
    this.carriers = [];
    //fetches all carriers based on business line name
    this.sample.carriers.forEach((element) => {
      if (element.businessLine == lobName) this.carriers.push(element);
    });
    // deselects the business line accordion
    this.accordionSelectionArray[0] = false;
    //selects the carrier  accordion
    this.accordionSelectionArray[1] = true;
    // enables the carrier accordion
    this.accordionDisabledArray[1] = false;
    // stores the lob name for accordion header
    this.accordionHeader[0] = lobName;
    // carrier header will be set null
    this.accordionHeader[1] = null;
  }

  getDocuments(carrierLable, index, carrierName) {
    // clears the existing documents and stores them based on the carrier name
    this.lastselectedcarrier = index;
    this.documents = [];
    // all documents based on carriers will be available here
    this.sample.documents.forEach((element) => {
      if (element.carrier == carrierName) this.documents.push(element);
    });
    // deselects the carrier  accordion
    this.accordionSelectionArray[1] = false;
    // disables the carrier accordion
    this.accordionDisabledArray[1] = false;
    // selects the carrier documents
    this.accordionSelectionArray[2] = true;
    // enables the carrier documents
    this.accordionDisabledArray[2] = false;
    // sets the carrier header
    this.accordionHeader[1] = carrierLable;
  }
  enableCurrentAccordion(index) {
    // if business line is chosen, then the carrier and its documents are cleared out
    if (index == 0) {
      this.carriers = [];
      this.documents = [];
    }
    // only documents gets cleared out if carrier is selectd
    else {
      this.documents = [];
    }
    // current selected accordion is made to null;
    this.accordionHeader[index] = null;
    // selects and enables the current accordion
    for (var i = 0; i < this.sample.samples.length; i++) {
      if (i == index) {
        this.accordionSelectionArray[i] = true;
        this.accordionDisabledArray[i] = false;
      }
      // deselects the rest accordion
      else this.accordionSelectionArray[i] = false;
      // disables the rest accordion
      if (i > index) {
        this.accordionDisabledArray[i] = true;
      }
    }
  }
}
