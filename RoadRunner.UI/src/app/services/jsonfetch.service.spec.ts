import { TestBed } from '@angular/core/testing';

import { JsonfetchService } from './jsonfetch.service';

describe('JsonfetchService', () => {
  let service: JsonfetchService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JsonfetchService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
