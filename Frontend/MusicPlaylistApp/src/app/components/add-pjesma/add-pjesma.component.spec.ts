import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPjesmaComponent } from './add-pjesma.component';

describe('AddPjesmaComponent', () => {
  let component: AddPjesmaComponent;
  let fixture: ComponentFixture<AddPjesmaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddPjesmaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddPjesmaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
