import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-deposit',
  standalone: true,
  imports: [CommonModule, FormsModule, EmployeedashboardComponent, RouterModule],
  templateUrl: './deposit.component.html',
  styleUrl: './deposit.component.css'
})
export class DepositComponent implements OnInit {
  depositAmount: number = 0;

  constructor(private router: Router) { }
  cancel()
  {
    this.router.navigate(['/accountlist']);
  }

  ngOnInit(): void {
  }

  onDeposit() {
    alert("Amount Deposited successfully!");
    
  }
}
