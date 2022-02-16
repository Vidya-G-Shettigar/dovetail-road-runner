import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SamplePoliciesRoutingModule } from './sample-policies-routing.module';

import { SamplePoliciesComponent } from '../../../components/resources/sample-policies/sample-policies.component';

import { SharedModule } from '../../shared/shared.module';

import { AccordionModule } from 'primeng/accordion';

@NgModule({
  declarations: [SamplePoliciesComponent],
  imports: [
    CommonModule,
    SamplePoliciesRoutingModule,
    SharedModule,
    AccordionModule,
  ],
})
export class SamplePoliciesModule {}
