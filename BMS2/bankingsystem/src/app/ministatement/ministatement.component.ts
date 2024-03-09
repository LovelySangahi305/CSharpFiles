import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CustomernavbarComponent } from '../customernavbar/customernavbar.component';

@Component({
  selector: 'app-ministatement',
  standalone: true,
  imports: [ CustomernavbarComponent , RouterModule ],
  templateUrl: './ministatement.component.html',
  styleUrl: './ministatement.component.css'
})
export class MinistatementComponent {

}
