import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { AccountList } from '../accountlist.model';
import { EmployeedashboardComponent } from '../employeedashboard/employeedashboard.component';

@Component({
  selector: 'app-account-list',
  standalone: true,
  imports: [CommonModule, EmployeedashboardComponent],
  templateUrl: './account-list.component.html',
  styleUrl: './account-list.component.css'
})
export class AccountListComponent implements OnInit {
  accounts: AccountList[] = [ ];
  constructor() { }

  ngOnInit(): void {
  
    this.accounts = [ ];
}
}
