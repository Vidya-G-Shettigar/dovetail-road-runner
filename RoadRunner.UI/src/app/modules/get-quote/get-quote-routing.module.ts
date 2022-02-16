import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { GetQuoteComponent } from '../../components/get-quote/get-quote.component';

const routes: Routes = [
  {
    path: '',
    component: GetQuoteComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GetQuoteRoutingModule { }
