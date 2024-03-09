import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageraccountlistComponent } from './manageraccountlist.component';

describe('ManageraccountlistComponent', () => {
  let component: ManageraccountlistComponent;
  let fixture: ComponentFixture<ManageraccountlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManageraccountlistComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManageraccountlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
