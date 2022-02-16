import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardTileComponent } from './card-tile.component';

describe('CardTileComponent', () => {
  let component: CardTileComponent;
  let fixture: ComponentFixture<CardTileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CardTileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CardTileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
