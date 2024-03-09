import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { CustomernavbarComponent } from '../customernavbar/customernavbar.component';

@Component({
  selector: 'app-addbeneficiary',
  standalone: true,
  imports: [ CustomernavbarComponent ,RouterModule , CommonModule , FormsModule],
  templateUrl: './addbeneficiary.component.html',
  styleUrl: './addbeneficiary.component.css'
})
export class AddbeneficiaryComponent {

  onSubmit(accountForm: NgForm) {
    alert("Beneficiary Added successfully!")
     }
     constructor(private router: Router) { }
     cancel()
     {
       this.router.navigate(['/customernavbar']);
     }
}
