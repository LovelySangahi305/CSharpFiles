import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagercreatecustomerComponent } from './managercreatecustomer.component';

describe('ManagercreatecustomerComponent', () => {
  let component: ManagercreatecustomerComponent;
  let fixture: ComponentFixture<ManagercreatecustomerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagercreatecustomerComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagercreatecustomerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
