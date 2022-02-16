import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ResourcesRoutingModule } from './resources-routing.module';
import { ResourcesLayoutComponent } from './resources-layout/resources-layout.component';
import { ResourcesComponent } from '../../components/resources/resources.component';
import { BannerComponent } from '../../components/resources/banner/banner.component';
import { ResourceCardComponent } from '../../components/resources/resource-card/resource-card.component';
import { SharedModule } from './../shared/shared.module';

@NgModule({
  declarations: [
    ResourcesLayoutComponent,
    ResourcesComponent,
    BannerComponent,
    ResourceCardComponent,
  ],
  imports: [CommonModule, ResourcesRoutingModule, SharedModule],
})
export class ResourcesModule {}
