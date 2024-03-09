import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AccountService } from '../account.service';
import { CustomernavbarComponent } from '../customernavbar/customernavbar.component';

@Component({
  selector: 'app-accountinfo',
  standalone: true,
  imports: [ CustomernavbarComponent , RouterModule , CommonModule],
  templateUrl: './accountinfo.component.html',
  styleUrl: './accountinfo.component.css'
})
export class AccountinfoComponent
{
  accountDetails: any;
}
// export class AccountinfoComponent implements OnInit {
//   accountDetails: any;

//   constructor(private accountService: AccountService) { }

//   ngOnInit(): void {
//     this.getAccountDetails();
//   }

//   getAccountDetails(): void {
//     this.accountService.getAccountDetails()
//       .subscribe((data) => {
//         this.accountDetails = data;
//       });
//   }
// }
