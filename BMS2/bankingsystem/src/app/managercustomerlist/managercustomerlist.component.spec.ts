import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagercustomerlistComponent } from './managercustomerlist.component';

describe('ManagercustomerlistComponent', () => {
  let component: ManagercustomerlistComponent;
  let fixture: ComponentFixture<ManagercustomerlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagercustomerlistComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagercustomerlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
