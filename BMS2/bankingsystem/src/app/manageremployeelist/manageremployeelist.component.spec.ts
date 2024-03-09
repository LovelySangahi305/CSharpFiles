import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageremployeelistComponent } from './manageremployeelist.component';

describe('ManageremployeelistComponent', () => {
  let component: ManageremployeelistComponent;
  let fixture: ComponentFixture<ManageremployeelistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManageremployeelistComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManageremployeelistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
