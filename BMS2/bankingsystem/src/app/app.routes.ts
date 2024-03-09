import { Routes } from '@angular/router';
import { AboutusComponent } from './aboutus/aboutus.component';
import { AccountListComponent } from './account-list/account-list.component';
import { AccountinfoComponent } from './accountinfo/accountinfo.component';
import { AddbeneficiaryComponent } from './addbeneficiary/addbeneficiary.component';
import { BeneficiariesComponent } from './beneficiaries/beneficiaries.component';
import { ContactComponent } from './contact/contact.component';
import { CreateAccountComponent } from './create-account/create-account.component';
import { CreateCustomerComponent } from './create-customer/create-customer.component';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { CustomerloginComponent } from './customerlogin/customerlogin.component';
import { CustomernavbarComponent } from './customernavbar/customernavbar.component';
import { CustomersignupComponent } from './customersignup/customersignup.component';
import { DepositComponent } from './deposit/deposit.component';
import { EmployeedashboardComponent } from './employeedashboard/employeedashboard.component';
import { EmployeeloginComponent } from './employeelogin/employeelogin.component';
import { FundtransferComponent } from './fundtransfer/fundtransfer.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ManageraccountlistComponent } from './manageraccountlist/manageraccountlist.component';
import { ManagercreateaccountComponent } from './managercreateaccount/managercreateaccount.component';
import { ManagercreatecustomerComponent } from './managercreatecustomer/managercreatecustomer.component';
import { ManagercreateemployeeComponent } from './managercreateemployee/managercreateemployee.component';
import { ManagercustomerlistComponent } from './managercustomerlist/managercustomerlist.component';
import { ManageremployeelistComponent } from './manageremployeelist/manageremployeelist.component';
import { ManagerfundtransferComponent } from './managerfundtransfer/managerfundtransfer.component';
import { ManagerloginComponent } from './managerlogin/managerlogin.component';
import { ManagernavbarComponent } from './managernavbar/managernavbar.component';
import { MinistatementComponent } from './ministatement/ministatement.component';
import { UpdatedetailsComponent } from './updatedetails/updatedetails.component';
import { WithdrawComponent } from './withdraw/withdraw.component';

    export const routes: Routes = [

    { path: '', component: HomepageComponent },

    { path: 'homepage', component: HomepageComponent },

    { path: 'aboutus', component: AboutusComponent },

    { path: 'contact', component: ContactComponent },

    { path: 'customerlogin', component: CustomerloginComponent },

    { path: 'managerlogin', component: ManagerloginComponent },

    { path: 'employeelogin', component: EmployeeloginComponent },

    { path: 'customersignup', component: CustomersignupComponent },

    { path: 'employeedashboard', component:  EmployeedashboardComponent },

    { path: 'withdrawal', component:  WithdrawComponent },

    { path: 'deposit', component:  DepositComponent },

    { path: 'fundtransfer', component:  FundtransferComponent },

    { path: 'customerlist', component:  CustomerListComponent },

    { path: 'accountlist', component:  AccountListComponent },

    { path: 'createcustomer', component:  CreateCustomerComponent },

    { path: 'createaccount', component:  CreateAccountComponent },

    { path: 'managernavbar' , component: ManagernavbarComponent },

    { path: 'managercreateemployee' , component: ManagercreateemployeeComponent },

    { path: 'managercreateaccount' , component: ManagercreateaccountComponent },

    { path: 'managercreatecustomer' , component: ManagercreatecustomerComponent },

    { path: 'manageremployeelist' , component: ManageremployeelistComponent },

    { path: 'manageraccountlist' , component: ManageraccountlistComponent },

    { path: 'managercustomerlist' , component: ManagercustomerlistComponent },

    { path: 'managerfundtransfer' , component: ManagerfundtransferComponent },

    { path: 'customernavbar', component: CustomernavbarComponent },

    { path: 'addbeneficiary' , component: AddbeneficiaryComponent },

    { path: 'updatedetails' , component: UpdatedetailsComponent },

    { path: 'accountinfo', component: AccountinfoComponent },

    { path: 'ministatement' , component: MinistatementComponent },

    { path: 'beneficiaries', component: BeneficiariesComponent }

    ];
