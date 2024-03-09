import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm, NgModel } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { createemployee } from '../createemployee.model';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';
import { EmployeeList } from '../employeelist.model';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-managercreateemployee',
  standalone: true,
  imports: [CommonModule, FormsModule , ManagernavbarComponent, RouterModule],
  templateUrl: './managercreateemployee.component.html',
  styleUrl: './managercreateemployee.component.css'
})
export class ManagercreateemployeeComponent {
  //employee: createemployee = {};

  onSubmit(employeeForm: NgForm) {
    alert("Employee created successfully!")
     }
     constructor(private router: Router) { }
     cancel()
     {
       this.router.navigate(['/employeelist']);
     }

     validateDOB(dob :NgModel) {
      if (dob.value) {
        const currentDate = new Date();
        const dobDate = new Date(dob.value);
        let age = currentDate.getFullYear() - dobDate.getFullYear();
        const monthDiff = currentDate.getMonth() - dobDate.getMonth();
        if (monthDiff < 0 || (monthDiff === 0 && currentDate.getDate() < dobDate.getDate())) {
          age--;
        }
        if (age < 23 ) {
          dob.control.setErrors({ ageInvalid: true });
        } else {
          dob.control.setErrors(null);
        }
      }
  }

}
