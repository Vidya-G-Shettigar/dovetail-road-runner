import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PortfoliosComponent } from '../../components/portfolios/portfolios.component';

const routes: Routes = [
  {
    path: '',
    component: PortfoliosComponent,
  },
  {
    path: 'quotes',
    loadChildren: () =>
      import('./quotes/quotes.module').then((m) => m.QuotesModule),
  },

  {
    path: 'policies',
    loadChildren: () =>
      import('./policies/policies.module').then((m) => m.PoliciesModule),
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PortfolioRoutingModule {}
