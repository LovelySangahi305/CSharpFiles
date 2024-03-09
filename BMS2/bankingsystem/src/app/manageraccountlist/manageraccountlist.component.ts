import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AccountList } from '../accountlist.model';
import { ManagernavbarComponent } from '../managernavbar/managernavbar.component';

@Component({
  selector: 'app-manageraccountlist',
  standalone: true,
  imports: [ManagernavbarComponent, CommonModule],
  templateUrl: './manageraccountlist.component.html',
  styleUrl: './manageraccountlist.component.css'
})
export class ManageraccountlistComponent {
  accounts: AccountList[] = [ ];
  constructor() { }

  ngOnInit(): void {
  
    this.accounts = [ ];
}
}
