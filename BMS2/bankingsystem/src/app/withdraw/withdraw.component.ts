import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-withdraw',
  standalone: true,
  imports: [CommonModule, FormsModule, EmployeedashboardComponent],
  templateUrl: './withdraw.component.html',
  styleUrl: './withdraw.component.css'
})
export class WithdrawComponent implements OnInit{
  withdrawAmount: number = 0;

  constructor() { }

  ngOnInit(): void {
  }

  onWithdraw() {
    console.log('Withdraw amount:', this.withdrawAmount);
    
  }
}
