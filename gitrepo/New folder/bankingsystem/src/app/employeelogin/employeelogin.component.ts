import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-employeelogin',
  standalone: true,
  imports: [CommonModule, FormsModule ,RouterModule , EmployeedashboardComponent],
  templateUrl: './employeelogin.component.html',
  styleUrl: './employeelogin.component.css'
})
export class EmployeeloginComponent {
  username: string = '';
  password: string = '';

  constructor(private router: Router) { }
  empsubmit() {
    this.router.navigate(['accountlist']); // Replace 'login' with the path of the component you want to navigate to
  }

}
