import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagercreateaccountComponent } from './managercreateaccount.component';

describe('ManagercreateaccountComponent', () => {
  let component: ManagercreateaccountComponent;
  let fixture: ComponentFixture<ManagercreateaccountComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagercreateaccountComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagercreateaccountComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
