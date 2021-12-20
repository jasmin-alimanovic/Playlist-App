import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PjesmeComponent } from './pjesme.component';

describe('PjesmeComponent', () => {
  let component: PjesmeComponent;
  let fixture: ComponentFixture<PjesmeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PjesmeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PjesmeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
