import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { createcustomer } from '../createcustomer.model';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-create-customer',
  standalone: true,
  imports: [CommonModule , FormsModule , EmployeedashboardComponent],
  templateUrl: './create-customer.component.html',
  styleUrl: './create-customer.component.css'
})
export class CreateCustomerComponent {
  customer: createcustomer = {
    firstName: '',
    lastName: '',
    email: '',
    phoneNumber: 9876543210,
    address: '',
    dob: new Date(),
    gender: ''
  };

  onSubmit(form: NgForm) {
    if (form.valid) {
      console.log(this.customer); // Submit the form data to the backend or perform other actions
    }
  }
}
