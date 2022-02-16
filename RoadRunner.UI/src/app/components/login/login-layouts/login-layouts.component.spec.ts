import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginLayoutsComponent } from './login-layouts.component';

describe('LoginLayoutsComponent', () => {
  let component: LoginLayoutsComponent;
  let fixture: ComponentFixture<LoginLayoutsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoginLayoutsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginLayoutsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
