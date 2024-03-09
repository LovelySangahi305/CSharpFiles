import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { EmployeeList } from '../employeelist.model';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-manageremployeelist',
  standalone: true,
  imports:  [ ManagernavbarComponent, CommonModule ],
  templateUrl: './manageremployeelist.component.html',
  styleUrl: './manageremployeelist.component.css'
})
export class ManageremployeelistComponent {
  employees: EmployeeList[] = []; 

  constructor() { }

  ngOnInit(): void {
  
    this.employees = [ ];
  }
}
