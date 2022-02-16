import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AppetiteChecksRoutingModule } from './appetite-checks-routing.module';
import { AppetiteChecksComponent } from '../../../components/resources/appetite-checks/appetite-checks.component';

import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [AppetiteChecksComponent],
  imports: [CommonModule, AppetiteChecksRoutingModule, SharedModule],
})
export class AppetiteChecksModule {}
