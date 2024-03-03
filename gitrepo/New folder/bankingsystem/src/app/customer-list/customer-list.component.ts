import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { CustomerList } from '../customerlist.model';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-customer-list',
  standalone: true,
  imports: [CommonModule, EmployeedashboardComponent],
  templateUrl: './customer-list.component.html',
  styleUrl: './customer-list.component.css'
})
export class CustomerListComponent implements OnInit{
  customers: CustomerList[] = []; 

  constructor() { }

  ngOnInit(): void {
  
    this.customers = [ ];
  }
}
