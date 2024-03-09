import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm, NgModel } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { createcustomer } from '../createcustomer.model';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-managercreatecustomer',
  standalone: true,
  imports: [CommonModule, FormsModule, ManagernavbarComponent , RouterModule],
  templateUrl: './managercreatecustomer.component.html',
  styleUrl: './managercreatecustomer.component.css'
})
export class ManagercreatecustomerComponent {
 // customer: createcustomer = {};

  onSubmit(customerForm: NgForm) {
    alert("Customer created successfully!")
     }
     constructor(private router: Router) { }
     cancel()
     {
       this.router.navigate(['/customerlist']);
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
