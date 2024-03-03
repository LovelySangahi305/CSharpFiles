import { Routes } from '@angular/router';
import { AboutusComponent } from './aboutus/aboutus.component';
import { AccountListComponent } from './account-list/account-list.component';
import { ContactComponent } from './contact/contact.component';
import { CreateAccountComponent } from './create-account/create-account.component';
import { CreateCustomerComponent } from './create-customer/create-customer.component';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { CustomerloginComponent } from './customerlogin/customerlogin.component';
import { CustomersignupComponent } from './customersignup/customersignup.component';
import { DepositComponent } from './deposit/deposit.component';
import { EmployeedashboardComponent } from './employeedashboard/employeedashboard.component';
import { EmployeeloginComponent } from './employeelogin/employeelogin.component';
import { FundtransferComponent } from './fundtransfer/fundtransfer.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ManagerloginComponent } from './managerlogin/managerlogin.component';
import { WithdrawComponent } from './withdraw/withdraw.component';

    export const routes: Routes = [

    { path: '',component: HomepageComponent},

    { path: 'homepage', component: HomepageComponent },

    { path: 'aboutus', component: AboutusComponent },

    { path: 'contact', component: ContactComponent },

    { path: 'customerlogin', component: CustomerloginComponent },

    { path: 'managerlogin', component: ManagerloginComponent },

    { path: 'employeelogin', component: EmployeeloginComponent },

    { path: 'customersignup', component: CustomersignupComponent },

    { path: 'employeedashboard', component:  EmployeedashboardComponent},

    { path: 'withdraw', component:  WithdrawComponent},

    { path: 'deposit', component:  DepositComponent},

    {path: 'fundtransfer',component:  FundtransferComponent },

    {path: 'customerlist',component:  CustomerListComponent },

    {path: 'accountlist',component:  AccountListComponent },

    {path: 'createcustomer',component:  CreateCustomerComponent },

    {path: 'createaccount',component:  CreateAccountComponent },

    ];
