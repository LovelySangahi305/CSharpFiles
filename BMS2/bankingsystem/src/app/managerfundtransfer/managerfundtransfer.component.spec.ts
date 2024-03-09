import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerfundtransferComponent } from './managerfundtransfer.component';

describe('ManagerfundtransferComponent', () => {
  let component: ManagerfundtransferComponent;
  let fixture: ComponentFixture<ManagerfundtransferComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagerfundtransferComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagerfundtransferComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
