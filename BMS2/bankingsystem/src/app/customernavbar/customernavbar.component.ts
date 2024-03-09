import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-customernavbar',
  standalone: true,
  imports: [ CommonModule , RouterModule],
  templateUrl: './customernavbar.component.html',
  styleUrl: './customernavbar.component.css'
})
export class CustomernavbarComponent {
  constructor(private router: Router) { }
  accountinfo()
  {
    this.router.navigate(['accountinfo']);
  }
  beneficiaries()
  {
    this.router.navigate(['beneficiaries']);
  }
  addbeneficiary() 
  {
    this.router.navigate(['addbeneficiary']); 
  }
  updatedetails()
  {
    this.router.navigate(['updatedetails']); 
  }
  ministatement()
  {
    this.router.navigate(['ministatement']); 
  }
  logout() 
  {
    this.router.navigate(['homepage']); 
  }
}
