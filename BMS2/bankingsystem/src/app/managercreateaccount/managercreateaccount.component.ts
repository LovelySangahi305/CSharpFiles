import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-managercreateaccount',
  standalone: true,
  imports: [ ManagernavbarComponent, RouterModule, CommonModule, FormsModule],
  templateUrl: './managercreateaccount.component.html',
  styleUrl: './managercreateaccount.component.css'
})
export class ManagercreateaccountComponent {
  onSubmit(accountForm: NgForm) {
    alert("Account created successfully!")
     }
     constructor(private router: Router) { }
     cancel()
     {
       this.router.navigate(['/managernavbar']);
     }
}
