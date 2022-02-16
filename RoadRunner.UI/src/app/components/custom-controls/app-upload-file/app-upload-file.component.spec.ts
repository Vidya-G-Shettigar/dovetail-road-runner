import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppUploadFileComponent } from './app-upload-file.component';

describe('AppUploadFileComponent', () => {
  let component: AppUploadFileComponent;
  let fixture: ComponentFixture<AppUploadFileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppUploadFileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppUploadFileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
