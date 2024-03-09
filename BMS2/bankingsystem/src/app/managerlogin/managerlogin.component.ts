import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { AccountListComponent } from '../account-list/account-list.component';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-managerlogin',
  standalone: true,
  imports: [CommonModule , FormsModule , RouterModule ],
  templateUrl: './managerlogin.component.html',
  styleUrl: './managerlogin.component.css'
})
export class ManagerloginComponent {
  constructor(private router: Router) { }

  managersubmit()
  {
    alert("Successful Login!");
    this.router.navigate(['/manageraccountlist']);
  }
  cancel()
  {
    this.router.navigate(['/homepage']);
  }
}
