import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CustomernavbarComponent } from '../customernavbar/customernavbar.component';

@Component({
  selector: 'app-beneficiaries',
  standalone: true,
  imports: [CustomernavbarComponent, RouterModule],
  templateUrl: './beneficiaries.component.html',
  styleUrl: './beneficiaries.component.css'
})
export class BeneficiariesComponent {

}
