import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { GlobalHeadderComponent } from '../../components/shared/global-headder/global-headder.component';
import { GlobalFooterComponent } from '../../components/shared/global-footer/global-footer.component';
import { GlobalSmallBannerComponent } from '../../components/shared/global-small-banner/global-small-banner.component';
// import { CarouselModule } from 'primeng/carousel';

import { FileUploadModule } from 'primeng/fileupload';
import { HttpClientModule } from '@angular/common/http';

import { TableModule } from 'primeng/table';
import { ToastModule } from 'primeng/toast';
import { CalendarModule } from 'primeng/calendar';
import { SliderModule } from 'primeng/slider';
import { MultiSelectModule } from 'primeng/multiselect';
import { ContextMenuModule } from 'primeng/contextmenu';
import { DialogModule } from 'primeng/dialog';
import { ButtonModule } from 'primeng/button';
import { DropdownModule } from 'primeng/dropdown';
import { ProgressBarModule } from 'primeng/progressbar';
import { InputTextModule } from 'primeng/inputtext';
import { FormsModule } from '@angular/forms';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { MatIconModule } from '@angular/material/icon';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { CheckboxModule } from 'primeng/checkbox';

@NgModule({
  declarations: [
    GlobalHeadderComponent,
    GlobalFooterComponent,
    GlobalSmallBannerComponent,
  ],
  imports: [
    CommonModule,
    RouterModule,
    TableModule,
    CalendarModule,
    SliderModule,
    DialogModule,
    MultiSelectModule,
    ContextMenuModule,
    DropdownModule,
    ButtonModule,
    ToastModule,
    InputTextModule,
    ProgressBarModule,
    FormsModule,
    ScrollingModule,
    MatIconModule,
    AutoCompleteModule,
    CheckboxModule,
    FileUploadModule,
    HttpClientModule,
  ],
  exports: [
    GlobalHeadderComponent,
    GlobalFooterComponent,
    GlobalSmallBannerComponent,
    TableModule,
    CalendarModule,
    SliderModule,
    DialogModule,
    MultiSelectModule,
    ContextMenuModule,
    DropdownModule,
    ButtonModule,
    ToastModule,
    InputTextModule,
    ProgressBarModule,
    FormsModule,
    ScrollingModule,
    AutoCompleteModule,
    CheckboxModule,
    HttpClientModule,
    FileUploadModule,
  ],
})
export class SharedModule {}
