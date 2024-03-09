import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { CustomerList } from '../customerlist.model';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-managercustomerlist',
  standalone: true,
  imports: [ManagernavbarComponent , CommonModule],
  templateUrl: './managercustomerlist.component.html',
  styleUrl: './managercustomerlist.component.css'
})
export class ManagercustomerlistComponent {
  customers: CustomerList[] = []; 

  constructor() { }

  ngOnInit(): void {
  
    this.customers = [ ];
  }
}
