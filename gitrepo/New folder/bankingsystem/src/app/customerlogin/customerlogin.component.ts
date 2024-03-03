import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-customerlogin',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterModule],
  templateUrl: './customerlogin.component.html',
  styleUrl: './customerlogin.component.css'
})
export class CustomerloginComponent {

  username: string = '';
  password: string = '';

  onSubmit() {
    if (this.username && this.password) {
    
      console.log('Username:', this.username);
      console.log('Password:', this.password);
    }
  }
  constructor(private router: Router) { }
  customersignup() {
    this.router.navigate(['customersignup']);
  } 
}
