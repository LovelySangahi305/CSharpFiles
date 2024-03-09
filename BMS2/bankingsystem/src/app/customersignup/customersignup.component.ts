import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormsModule, NgForm, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-customersignup',
  standalone: true,
  imports: [FormsModule , CommonModule , RouterModule],
  templateUrl: './customersignup.component.html',
  styleUrl: './customersignup.component.css'
})
export class CustomersignupComponent {
  constructor(private router: Router) { }

  onSubmit(form: NgForm) {

    if (form.valid) {
     alert('Form submitted successfully!');
  this.router.navigate(['accountlist']);
    }
  }
    cancel()
    {
      this.router.navigate(['homepage']);
    }
}