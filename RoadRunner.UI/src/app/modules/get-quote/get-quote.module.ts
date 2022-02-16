import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GetQuoteRoutingModule } from './get-quote-routing.module';
import { QuotesComponent } from './quotes/quotes.component';

import { GetQuoteComponent } from '../../components/get-quote/get-quote.component';

import { SharedModule } from './../shared/shared.module';

@NgModule({
  declarations: [QuotesComponent, GetQuoteComponent],
  imports: [CommonModule, GetQuoteRoutingModule, SharedModule],
})
export class GetQuoteModule {}
