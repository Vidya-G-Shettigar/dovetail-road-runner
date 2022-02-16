import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SamplePoliciesComponent } from '../../../components/resources/sample-policies/sample-policies.component';

const routes: Routes = [
  {
    path: '',
    component: SamplePoliciesComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SamplePoliciesRoutingModule {}
