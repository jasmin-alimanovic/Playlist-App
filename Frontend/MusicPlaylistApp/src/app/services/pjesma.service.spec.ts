import { TestBed } from '@angular/core/testing';

import { PjesmaService } from './pjesma.service';

describe('PjesmaService', () => {
  let service: PjesmaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PjesmaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
