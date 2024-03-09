import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-employeelogin',
  standalone: true,
  imports: [CommonModule, FormsModule , RouterModule , EmployeedashboardComponent],
  templateUrl: './employeelogin.component.html',
  styleUrl: './employeelogin.component.css'
})
export class EmployeeloginComponent {
  constructor(private router: Router) { }
  empsubmit() {
    // alert("Successful Login!");
    this.router.navigate(['/accountlist']); // Replace 'login' with the path of the component you want to navigate to
  }
  cancel()
  {
    this.router.navigate(['/homepage']);
  }
}
