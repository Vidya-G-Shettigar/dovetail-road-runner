import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PoliciesRoutingModule } from './policies-routing.module';
import { PoliciesComponent } from '../../../components/portfolios/policies/policies.component';
import { SharedModule } from '../../shared/shared.module';

import {TableModule} from 'primeng/table';
import {ToastModule} from 'primeng/toast';
import {CalendarModule} from 'primeng/calendar';
import {SliderModule} from 'primeng/slider';
import {MultiSelectModule} from 'primeng/multiselect';
import {ContextMenuModule} from 'primeng/contextmenu';
import {DialogModule} from 'primeng/dialog';
import {ButtonModule} from 'primeng/button';
import {DropdownModule} from 'primeng/dropdown';
import {ProgressBarModule} from 'primeng/progressbar';
import {InputTextModule} from 'primeng/inputtext';
import {FormsModule} from '@angular/forms';
import {ScrollingModule} from '@angular/cdk/scrolling';
import { AutoCompleteModule } from "primeng/autocomplete";
import { PolicyConformationComponent } from 'src/app/components/portfolios/policies/policy-conformation/policy-conformation.component';
@NgModule({
  declarations: [PoliciesComponent,PolicyConformationComponent],
  imports: [CommonModule, PoliciesRoutingModule, SharedModule,
    TableModule,
    CalendarModule,
		SliderModule,
		DialogModule,
		MultiSelectModule,
		ContextMenuModule,
		DropdownModule,
		ButtonModule,
		ToastModule,
    InputTextModule,
    ProgressBarModule,
    FormsModule,ScrollingModule,AutoCompleteModule
  ],
})
export class PoliciesModule {}
