import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CustomernavbarComponent } from '../customernavbar/customernavbar.component';

@Component({
  selector: 'app-updatedetails',
  standalone: true,
  imports: [ CustomernavbarComponent , RouterModule ],
  templateUrl: './updatedetails.component.html',
  styleUrl: './updatedetails.component.css'
})
export class UpdatedetailsComponent {

}
