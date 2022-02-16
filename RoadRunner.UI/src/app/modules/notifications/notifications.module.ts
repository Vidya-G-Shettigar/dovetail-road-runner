import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatStepperModule } from '@angular/material/stepper';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';

import { NotificationsRoutingModule } from './notifications-routing.module';
import { NotificationsLayoutComponent } from './notifications-layout/notifications-layout.component';
import { NotificationsComponent } from '../../components/notifications/notifications.component';
import { SharedModule } from './../shared/shared.module';

@NgModule({
  declarations: [
    NotificationsLayoutComponent,
    NotificationsComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    MatStepperModule,
    MatFormFieldModule,
    FormsModule,
    ReactiveFormsModule,
    MatInputModule,
    NotificationsRoutingModule,
  ],
})
export class NotificationsModule { }
