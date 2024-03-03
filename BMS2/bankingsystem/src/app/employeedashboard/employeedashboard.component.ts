import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { DepositComponent } from '../deposit/deposit.component';
import { FundtransferComponent } from '../fundtransfer/fundtransfer.component';
import { WithdrawComponent } from '../withdraw/withdraw.component';

@Component({
  selector: 'app-employeedashboard',
  standalone: true,
  imports: [ WithdrawComponent, DepositComponent, FundtransferComponent, CommonModule , RouterModule],
  templateUrl: './employeedashboard.component.html',
  styleUrl: './employeedashboard.component.css'
})
export class EmployeedashboardComponent {

  constructor(private router: Router) { }

  accountlist()
  {
    this.router.navigate(['accountlist']);
  }
  customerlist()
  {
    this.router.navigate(['customerlist']);
  }
  withdraw() {
    this.router.navigate(['withdraw']); 
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
  
  
}
