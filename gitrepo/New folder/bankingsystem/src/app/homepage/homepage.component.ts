import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { CustomerloginComponent } from '../customerlogin/customerlogin.component';

@Component({
  selector: 'app-homepage',
  standalone: true,
  imports: [CommonModule ,RouterModule],
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.css'
})

export class HomepageComponent {
  constructor(private router: Router) { }
  
customerlogin() {
      this.router.navigate(['customerlogin']);
  }
 managerlogin() {
    this.router.navigate(['managerlogin']);
}
employeelogin() {
  this.router.navigate(['employeelogin']);
}
}
