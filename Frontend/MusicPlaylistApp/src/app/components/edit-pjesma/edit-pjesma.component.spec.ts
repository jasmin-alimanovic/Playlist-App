import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditPjesmaComponent } from './edit-pjesma.component';

describe('EditPjesmaComponent', () => {
  let component: EditPjesmaComponent;
  let fixture: ComponentFixture<EditPjesmaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditPjesmaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditPjesmaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
