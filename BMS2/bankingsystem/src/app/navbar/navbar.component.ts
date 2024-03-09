import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [ RouterModule , CommonModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  constructor(private router: Router) {}
  loggedIn: boolean = false;

  login() {
    this.loggedIn = true;
  }

  homepage()
  {
this.router.navigate(['/homepage']);
  }
  contact()
  {
    this.router.navigate(['/contact']);
  }
  aboutus()
  {
    this.router.navigate(['/aboutus']);
  }
  customerlogin()
  {
    this.router.navigate(['/customerlogin']);
  }
 managerlogin()
  {
    this.router.navigate(['/managerlogin']);
  }
  employeelogin()
  {
    this.router.navigate(['/employeelogin']);
  }

}
