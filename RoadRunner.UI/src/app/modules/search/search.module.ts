import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SearchRoutingModule } from './search-routing.module';
import { SearchLayoutComponent } from './search-layout/search-layout.component';

import { SearchComponent } from '../../components/search/search.component';

import { SharedModule } from './../shared/shared.module';

import { SearchPipe } from '../../components/search/search.pipe';

@NgModule({
  declarations: [SearchLayoutComponent, SearchComponent, SearchPipe],
  imports: [CommonModule, SearchRoutingModule, SharedModule, FormsModule],
})
export class SearchModule {}
