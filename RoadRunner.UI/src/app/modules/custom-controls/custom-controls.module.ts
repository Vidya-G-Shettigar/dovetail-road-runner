import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppButtonComponent } from '../../components/custom-controls/app-button/app-button.component';
import { AppUploadFileComponent } from '../../components/custom-controls/app-upload-file/app-upload-file.component';
@NgModule({
  declarations: [AppButtonComponent, AppUploadFileComponent],
  imports: [CommonModule],
  exports: [AppButtonComponent, AppUploadFileComponent],
})
export class CustomControlsModule {}
