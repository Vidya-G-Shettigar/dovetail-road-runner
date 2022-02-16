import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InsightsComponent } from '../../../components/resources/insights/insights.component';

const routes: Routes = [
  {
    path: '',
    component: InsightsComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class InsightsRoutingModule {}
