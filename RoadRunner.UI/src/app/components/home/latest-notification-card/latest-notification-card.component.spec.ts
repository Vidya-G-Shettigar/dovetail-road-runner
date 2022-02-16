import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LatestNotificationCardComponent } from './latest-notification-card.component';

describe('LatestNotificationCardComponent', () => {
  let component: LatestNotificationCardComponent;
  let fixture: ComponentFixture<LatestNotificationCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LatestNotificationCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LatestNotificationCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
