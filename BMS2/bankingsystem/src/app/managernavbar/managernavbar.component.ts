import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-managernavbar',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './managernavbar.component.html',
  styleUrl: './managernavbar.component.css'
})
export class ManagernavbarComponent {
  constructor(private router: Router) { }
  accountlist()
  {
    this.router.navigate(['manageraccountlist']);
  }
  customerlist()
  {
    this.router.navigate(['managercustomerlist']);
  }
 employeelist() {
    this.router.navigate(['manageremployeelist']); 
  }
  createcustomer()
  {
    this.router.navigate(['managercreatecustomer']); 
  }
  createaccount()
  {
    this.router.navigate(['managercreateaccount']); 
  }
  createemployee()
  {
    this.router.navigate(['managercreateemployee']); 
  }
  fundtransfer() {
    this.router.navigate(['managerfundtransfer']); 
  }
  logout() {
    this.router.navigate(['homepage']); 
  }
}
