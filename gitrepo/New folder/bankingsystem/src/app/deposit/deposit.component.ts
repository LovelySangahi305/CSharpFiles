import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-deposit',
  standalone: true,
  imports: [CommonModule, FormsModule, EmployeedashboardComponent],
  templateUrl: './deposit.component.html',
  styleUrl: './deposit.component.css'
})
export class DepositComponent implements OnInit {
  depositAmount: number = 0;

  constructor() { }

  ngOnInit(): void {
  }

  onDeposit() {
    console.log('Deposit amount:', this.depositAmount);
    
  }
}
