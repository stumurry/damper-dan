import { TestBed, inject } from '@angular/core/testing';

import { DamperService } from './damper.service';

describe('DamperService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DamperService]
    });
  });

  it('should be created', inject([DamperService], (service: DamperService) => {
    expect(service).toBeTruthy();
  }));
});
