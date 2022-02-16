import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-get-quote',
  templateUrl: './get-quote.component.html',
  styleUrls: ['./get-quote.component.css']
})
export class GetQuoteComponent implements OnInit {
  public buttonDisabled: any = {
    step1ContinueDisabled: true,
    step1NextDisabled: true
  };
  public activeSteps: any = {
    step1Complete: false,
    step2Complete: false,
    step3Complete: false,
    step4Complete: false,
    step5Complete: false
  };
  public completedSteps: any = {
    step1Complete: false,
    step2Complete: false,
    step3Complete: false,
    step4Complete: false,
    step5Complete: false
  };
  public step1Completion = 0;
  public step2Completion = 0;
  public step3Completion = 0;
  public step4Completion = 0;
  public step5Completion = 0;
  public showStep2: boolean = false;

  constructor() { }

  ngOnInit(): void { }

  // Function to calculate % completion
  calculatePercentageCompletion(value: any, step: any) {
    return (100 / value) * step;
  }

  // Function to calculate % completion for step 1
  calculatePercentageStep1(value: any, step: any, variable: any) {
    this.step1Completion = this.calculatePercentageCompletion(value, step);
    this.buttonDisabled[variable] = false;
    if (variable === '') {
      this.completedSteps.step1Complete = true;
      this.activeSteps.step2Complete = true;
      this.showStep2 = true;
    }
  }

  // Function to calculate % completion for step 2
  calculatePercentageStep2(value: any, step: any) {
    this.step2Completion = this.calculatePercentageCompletion(value, step);
    this.completedSteps.step2Complete = true;
    this.activeSteps.step3Complete = true;
    this.showStep2 = false;
  }

  // Function to call on click of edit in step 1
  onClickEditStep1() {
    this.completedSteps.step1Complete = false;
    const lists: any[] = ['step2Complete', 'step3Complete', 'step4Complete', 'step5Complete'];
    this.onClickEdit(lists);
  }

  // Function to call on click of edit in step 2
  onClickEditStep2() {
    this.completedSteps.step2Complete = false;
    const lists: any[] = ['step3Complete', 'step4Complete', 'step5Complete'];
    this.onClickEdit(lists);
    this.showStep2 = true;
  }

  // Function to call on click of edit
  onClickEdit(lists: any[]) {
    lists.forEach(list => {
      this.completedSteps[list] = false;
      this.activeSteps[list] = false;
    });
  }
}
