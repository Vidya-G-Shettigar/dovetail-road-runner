import { SharedModule } from './../shared/shared.module';

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatStepperModule } from '@angular/material/stepper';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PortfolioRoutingModule } from './portfolio-routing.module';
import { PortfolioLayoutComponent } from './portfolio-layout/portfolio-layout.component';
import { PortfoliosComponent } from '../../components/portfolios/portfolios.component';

import { PortfoliosCardsComponent } from '../../components/portfolios/portfolios-cards/portfolios-cards.component';

import { BannerComponent } from '../../components/portfolios/banner/banner.component';
import { MatInputModule } from '@angular/material/input';
@NgModule({
  declarations: [
    PortfolioLayoutComponent,
    PortfoliosComponent,
    PortfoliosCardsComponent,
    BannerComponent,
  ],
  imports: [
    CommonModule,
    PortfolioRoutingModule,
    SharedModule,
    MatStepperModule,
    MatFormFieldModule,
    FormsModule,
    ReactiveFormsModule,
    MatInputModule,
  ],
})
export class PortfolioModule {}
