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

  constructor(private router: Router) { }
  onsubmit()
  {
    // alert("Successful Login!");
    this.router.navigate(['/customernavbar']);
  }
  customersignup() {
    alert("SignUp Successful!");
    this.router.navigate(['/customersignup']);
  } 
  cancel()
  {
    this.router.navigate(['/homepage']);
  }
}
