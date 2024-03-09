import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AboutusComponent } from './aboutus/aboutus.component';
import { ContactComponent } from './contact/contact.component';
import { CustomerloginComponent } from './customerlogin/customerlogin.component';
import { DepositComponent } from './deposit/deposit.component';
import { EmployeedashboardComponent } from './employeedashboard/employeedashboard.component';
import { EmployeeloginComponent } from './employeelogin/employeelogin.component';
import { FooterComponent } from './footer/footer.component';
import { FundtransferComponent } from './fundtransfer/fundtransfer.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ManagercreatecustomerComponent } from './managercreatecustomer/managercreatecustomer.component';
import { ManagercreateemployeeComponent } from './managercreateemployee/managercreateemployee.component';
import { ManagerloginComponent } from './managerlogin/managerlogin.component';
import { ManagernavbarComponent } from './managernavbar/managernavbar.component';
import { NavbarComponent } from './navbar/navbar.component';
import { WithdrawComponent } from './withdraw/withdraw.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet, NavbarComponent , FooterComponent, 
    HomepageComponent, CommonModule, EmployeeloginComponent, 
    CustomerloginComponent, ManagerloginComponent , AboutusComponent, ContactComponent ,
    EmployeedashboardComponent, WithdrawComponent , DepositComponent, FundtransferComponent , ManagernavbarComponent ,
     ManagercreatecustomerComponent , ManagercreateemployeeComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'bankingsystem';
}
