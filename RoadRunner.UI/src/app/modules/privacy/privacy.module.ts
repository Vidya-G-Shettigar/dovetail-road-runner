import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PrivacyRoutingModule } from './privacy-routing.module';
import { PrivacyLayoutComponent } from './privacy-layout/privacy-layout.component';
import { PrivacyComponent } from '../../components/privacy/privacy.component';
import { SharedModule } from './../shared/shared.module';

@NgModule({
  declarations: [PrivacyLayoutComponent, PrivacyComponent],
  imports: [CommonModule, PrivacyRoutingModule, SharedModule],
})
export class PrivacyModule {}
