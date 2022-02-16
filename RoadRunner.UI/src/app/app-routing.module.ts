import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeLayoutComponent } from './modules/home/home-layout/home-layout.component';
import { LoginLayoutComponent } from './modules/login/login-layout/login-layout.component';
import { PortfolioLayoutComponent } from './modules/portfolio/portfolio-layout/portfolio-layout.component';
import { ResourcesLayoutComponent } from './modules/resources/resources-layout/resources-layout.component';
import { ContactLayoutComponent } from './modules/contact-us/contact-layout/contact-layout.component';
import { QuotesComponent } from './modules/get-quote/quotes/quotes.component';
import { NotificationsLayoutComponent } from './modules/notifications/notifications-layout/notifications-layout.component';

import { TermsLayoutComponent } from './modules/terms/terms-layout/terms-layout.component';
import { PrivacyLayoutComponent } from './modules/privacy/privacy-layout/privacy-layout.component';
import { SearchLayoutComponent } from './modules/search/search-layout/search-layout.component';

const routes: Routes = [
  {
    path: '',
    component: HomeLayoutComponent,
    loadChildren: () =>
      import('./modules/home/home.module').then((m) => m.HomeModule),
  },

  {
    path: 'login',
    component: LoginLayoutComponent,
    loadChildren: () =>
      import('./modules/login/login.module').then((m) => m.LoginModule),
  },

  {
    path: 'notifications',
    component: NotificationsLayoutComponent,
    loadChildren: () =>
      import('./modules/notifications/notifications.module').then(
        (m) => m.NotificationsModule
      ),
  },

  {
    path: 'portfolio',
    component: PortfolioLayoutComponent,
    loadChildren: () =>
      import('./modules/portfolio/portfolio.module').then(
        (m) => m.PortfolioModule
      ),
  },

  {
    path: 'resources',
    component: ResourcesLayoutComponent,
    loadChildren: () =>
      import('./modules/resources/resources.module').then(
        (m) => m.ResourcesModule
      ),
  },

  {
    path: 'contact-us',
    component: ContactLayoutComponent,
    loadChildren: () =>
      import('./modules/contact-us/contact-us.module').then(
        (m) => m.ContactUsModule
      ),
  },

  {
    path: 'primary-rating-state',
    component: QuotesComponent,
    loadChildren: () =>
      import('./modules/get-quote/get-quote.module').then(
        (m) => m.GetQuoteModule
      ),
  },

  {
    path: 'terms',
    component: TermsLayoutComponent,
    loadChildren: () =>
      import('./modules/terms/terms.module').then((m) => m.TermsModule),
  },

  {
    path: 'privacy',
    component: PrivacyLayoutComponent,
    loadChildren: () =>
      import('./modules/privacy/privacy.module').then((m) => m.PrivacyModule),
  },

  {
    path: 'search-results',
    component: SearchLayoutComponent,
    loadChildren: () =>
      import('./modules/search/search.module').then((m) => m.SearchModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
