import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-fundtransfer',
  standalone: true,
  imports: [CommonModule, FormsModule, EmployeedashboardComponent, RouterModule],
  templateUrl: './fundtransfer.component.html',
  styleUrl: './fundtransfer.component.css'
})
export class FundtransferComponent {
  constructor(private router: Router) { }
  cancel()
  {
    this.router.navigate(['/accountlist']);
  }
  transferFunds() {
      alert("Funds transferred successfully!");
    }
}

