import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ResourcesComponent } from '../../components/resources/resources.component';

const routes: Routes = [
  {
    path: '',
    component: ResourcesComponent,
  },
  {
    path: 'appetite-checks',
    loadChildren: () =>
      import('./appetite-checks/appetite-checks.module').then(
        (m) => m.AppetiteChecksModule
      ),
  },

  {
    path: 'sample-policies',
    loadChildren: () =>
      import('./sample-policies/sample-policies.module').then(
        (m) => m.SamplePoliciesModule
      ),
  },

  {
    path: 'insights',
    loadChildren: () =>
      import('./insights/insights.module').then((m) => m.InsightsModule),
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ResourcesRoutingModule {}
