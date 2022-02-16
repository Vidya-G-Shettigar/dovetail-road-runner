import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactUsRoutingModule } from './contact-us-routing.module';
import { ContactLayoutComponent } from './contact-layout/contact-layout.component';
import { ContactUsComponent } from '../../components/contact-us/contact-us.component';

import { BannerComponent } from '../../components/contact-us/banner/banner.component';
import { LiveChatComponent } from '../../components/contact-us/live-chat/live-chat.component';

import { PhoneComponent } from '../../components/contact-us/phone/phone.component';
import { EmailComponent } from '../../components/contact-us/email/email.component';

import { SharedModule } from './../shared/shared.module';

@NgModule({
  declarations: [
    ContactLayoutComponent,
    ContactUsComponent,
    BannerComponent,
    LiveChatComponent,
    PhoneComponent,
    EmailComponent,
  ],
  imports: [CommonModule, ContactUsRoutingModule, SharedModule],
})
export class ContactUsModule {}
