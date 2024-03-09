import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-withdraw',
  standalone: true,
  imports: [CommonModule, FormsModule, EmployeedashboardComponent , RouterModule],
  templateUrl: './withdraw.component.html',
  styleUrl: './withdraw.component.css'
})
export class WithdrawComponent implements OnInit {
  withdrawAmount: number = 0;

  constructor(private router: Router) { }
  cancel()
  {
    this.router.navigate(['/accountlist']);
  }

  ngOnInit(): void {
  }

  onWithdraw() {
    alert("Amount withdrawn successfully!");
  }
}
