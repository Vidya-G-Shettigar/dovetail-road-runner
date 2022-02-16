import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InsightsRoutingModule } from './insights-routing.module';
import { InsightsComponent } from '../../../components/resources/insights/insights.component';
import { InsightsCardComponent } from '../../../components/resources/insights/insights-card/insights-card.component';

import { SharedModule } from '../../shared/shared.module';
@NgModule({
  declarations: [InsightsComponent, InsightsCardComponent],
  imports: [CommonModule, InsightsRoutingModule, SharedModule],
})
export class InsightsModule {}
