import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { DepositComponent } from '../deposit/deposit.component';
import { FundtransferComponent } from '../fundtransfer/fundtransfer.component';
import { WithdrawComponent } from '../withdraw/withdraw.component';

@Component({
  selector: 'app-employeedashboard',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './employeedashboard.component.html',
  styleUrl: './employeedashboard.component.css'
})
export class EmployeedashboardComponent {
  constructor(private router: Router) { }
// logout() {
//   this.router.navigate(['']);
// }
// withdraw() {
//   this.router.navigate(['withdraw']); 
// }
// deposit() {
//   this.router.navigate(['deposit']); 
// }
// transferFunds() {
//   this.router.navigate(['fundtransfer']); 
// }
// newAcc() {

// }
// newCustomer() {
//   this.router.navigate(['createcustomer']); 
// }
// customerList() {
//   this.router.navigate(['customerlist']);
// }
// accList() {
//   this.router.navigate(['accountlist']);
// }

  

  accountlist()
  {
    this.router.navigate(['accountlist']);
  }
  customerlist()
  {
    this.router.navigate(['customerlist']);
  }
  withdrawal() {
    this.router.navigate(['withdrawal']); 
  }
  deposit() {
    this.router.navigate(['deposit']); 
  }
  createcustomer()
  {
    this.router.navigate(['createcustomer']); 
  }
  createaccount()
  {
    this.router.navigate(['createaccount']); 
  }
  fundtransfer() {
    this.router.navigate(['fundtransfer']); 
  }
  logout() {
    this.router.navigate(['homepage']); 
  }
  
}
