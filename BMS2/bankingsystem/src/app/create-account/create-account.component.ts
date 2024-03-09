import { CommonModule } from '@angular/common';
import { EmitterVisitorContext } from '@angular/compiler';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { CommonEngine } from '@angular/ssr';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-create-account',
  standalone: true,
  imports: [CommonModule , FormsModule, EmployeedashboardComponent , RouterModule],
  templateUrl: './create-account.component.html',
  styleUrl: './create-account.component.css'
})
export class CreateAccountComponent {
 
  onSubmit(accountForm: NgForm) {
   alert("Account created successfully!")
    }
    constructor(private router: Router) { }
    cancel()
    {
      this.router.navigate(['/accountlist']);
    }
  }

