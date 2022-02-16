import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TermsRoutingModule } from './terms-routing.module';
import { TermsLayoutComponent } from './terms-layout/terms-layout.component';
import { TermsComponent } from '../../components/terms/terms.component';

import { SharedModule } from './../shared/shared.module';

@NgModule({
  declarations: [TermsLayoutComponent, TermsComponent],
  imports: [CommonModule, TermsRoutingModule, SharedModule],
})
export class TermsModule {}
