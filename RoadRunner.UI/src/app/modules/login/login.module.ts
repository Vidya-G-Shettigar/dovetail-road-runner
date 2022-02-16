import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from './../shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoginRoutingModule } from './login-routing.module';
import { LoginLayoutComponent } from './login-layout/login-layout.component';

import { LoginComponent } from '../../components/login/login.component';
import { LoginLayoutsComponent } from '../../components/login/login-layouts/login-layouts.component';

@NgModule({
  declarations: [LoginLayoutComponent, LoginLayoutsComponent, LoginComponent],
  imports: [
    CommonModule,
    LoginRoutingModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
  ],
})
export class LoginModule {
  ReactiveFormsModule;
}
