import { TestBed } from '@angular/core/testing';

import { JwtUnAuthrozedInterceptorService } from './jwt-un-authrozed-interceptor.service';

describe('JwtUnAuthrozedInterceptorService', () => {
  let service: JwtUnAuthrozedInterceptorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JwtUnAuthrozedInterceptorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
