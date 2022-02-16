import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GlobalHeadderComponent } from './global-headder.component';

describe('GlobalHeadderComponent', () => {
  let component: GlobalHeadderComponent;
  let fixture: ComponentFixture<GlobalHeadderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GlobalHeadderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GlobalHeadderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
