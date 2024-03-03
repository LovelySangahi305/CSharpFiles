import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-fundtransfer',
  standalone: true,
  imports: [CommonModule, FormsModule, EmployeedashboardComponent],
  templateUrl: './fundtransfer.component.html',
  styleUrl: './fundtransfer.component.css'
})
export class FundtransferComponent {
  constructor() { }
  transferFunds(fundTransferForm: NgForm) {
    // Handle fund transfer logic here
    if (fundTransferForm.valid) {
      // Implement fund transfer process
      console.log("Funds transferred successfully!");
    }
}
}
