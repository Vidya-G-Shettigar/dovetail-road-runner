import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { QuotesRoutingModule } from './quotes-routing.module';
import { QuotesComponent } from '../../../components/portfolios/quotes/quotes.component';
import { SharedModule } from '../../shared/shared.module';
import { QuotestableComponent } from 'src/app/components/portfolios/quotes/quotestable/quotestable.component';
import { AutoCompleteModule } from "primeng/autocomplete";

@NgModule({
  declarations: [QuotesComponent,QuotestableComponent],
  imports: [CommonModule, QuotesRoutingModule, SharedModule,AutoCompleteModule],
})
export class QuotesModule {}
