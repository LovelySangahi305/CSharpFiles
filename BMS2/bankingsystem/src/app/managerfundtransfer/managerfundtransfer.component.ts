import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-managerfundtransfer',
  standalone: true,
  imports: [ManagernavbarComponent, FormsModule , CommonModule, RouterModule],
  templateUrl: './managerfundtransfer.component.html',
  styleUrl: './managerfundtransfer.component.css'
})
export class ManagerfundtransferComponent {
  constructor(private router: Router) { }
  cancel()
  {
    this.router.navigate(['/managernavbar']);
  }
  transferFunds() {
      alert("Funds transferred successfully!");
    }
}
