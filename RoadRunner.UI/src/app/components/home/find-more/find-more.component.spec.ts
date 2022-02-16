import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FindMoreComponent } from './find-more.component';

describe('FindMoreComponent', () => {
  let component: FindMoreComponent;
  let fixture: ComponentFixture<FindMoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FindMoreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FindMoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
