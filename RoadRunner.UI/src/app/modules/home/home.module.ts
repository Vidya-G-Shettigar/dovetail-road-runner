import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeLayoutComponent } from './home-layout/home-layout.component';
import { CarouselModule } from 'primeng/carousel';
import { TabViewModule } from 'primeng/tabview';
import { ButtonModule } from 'primeng/button';

import { HomeComponent } from '../../components/home/home.component';
import { BannerComponent } from '../../components/home/banner/banner.component';
import { DashbordComponent } from '../../components/home/dashbord/dashbord.component';
import { GetQuotgetQuoteCardComponent } from '../../components/home/get-quotget-quote-card/get-quotget-quote-card.component';
import { QuickSummaryCardComponent } from '../../components/home/quick-summary-card/quick-summary-card.component';
import { LatestNotificationCardComponent } from '../../components/home/latest-notification-card/latest-notification-card.component';
import { RecentActivityComponent } from '../../components/home/recent-activity/recent-activity.component';
import { TableComponent } from '../../components/home/table/table.component';

import { ProductAvailabilityComponent } from '../../components/home/product-availability/product-availability.component';
import { FindMoreComponent } from '../../components/home/find-more/find-more.component';
import { CardTileComponent } from '../../components/home/card-tile/card-tile.component';
@NgModule({
  declarations: [
    HomeLayoutComponent,
    HomeComponent,
    BannerComponent,
    DashbordComponent,
    GetQuotgetQuoteCardComponent,
    QuickSummaryCardComponent,
    LatestNotificationCardComponent,
    RecentActivityComponent,
    TableComponent,
    ProductAvailabilityComponent,
    FindMoreComponent,
    CardTileComponent,
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    SharedModule,
    CarouselModule,
    TabViewModule,
    ButtonModule,
  ],
})
export class HomeModule {}
