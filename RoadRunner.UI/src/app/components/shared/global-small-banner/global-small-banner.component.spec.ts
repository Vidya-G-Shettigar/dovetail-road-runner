import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GlobalSmallBannerComponent } from './global-small-banner.component';

describe('GlobalSmallBannerComponent', () => {
  let component: GlobalSmallBannerComponent;
  let fixture: ComponentFixture<GlobalSmallBannerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GlobalSmallBannerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GlobalSmallBannerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
