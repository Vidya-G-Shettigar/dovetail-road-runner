import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PoliciesComponent } from '../../../components/portfolios/policies/policies.component';
import { PolicyConformationComponent } from 'src/app/components/portfolios/policies/policy-conformation/policy-conformation.component';
const routes: Routes = [
  {
    path: '',
    component: PoliciesComponent,
  },
  {
    path: 'conformation',
    component: PolicyConformationComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PoliciesRoutingModule {}
