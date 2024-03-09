import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm, NgModel } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { createcustomer } from '../createcustomer.model';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-create-customer',
  standalone: true,
  imports: [CommonModule , FormsModule , EmployeedashboardComponent, RouterModule],
  templateUrl: './create-customer.component.html',
  styleUrl: './create-customer.component.css'
})
export class CreateCustomerComponent {
  // customer: createcustomer = { };

  onSubmit(customerForm: NgForm) {
    alert("Customer created successfully!")
     }
     constructor(private router: Router) { }
     cancel()
     {
       this.router.navigate(['/accountlist']);
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
        if (age < 18) {
          dob.control.setErrors({ ageInvalid: true });
        } else {
          dob.control.setErrors(null);
        }
      }
}
}
