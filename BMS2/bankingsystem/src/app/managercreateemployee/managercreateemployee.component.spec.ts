import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagercreateemployeeComponent } from './managercreateemployee.component';

describe('ManagercreateemployeeComponent', () => {
  let component: ManagercreateemployeeComponent;
  let fixture: ComponentFixture<ManagercreateemployeeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagercreateemployeeComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagercreateemployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
