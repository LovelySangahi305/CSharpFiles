import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-managerlogin',
  standalone: true,
  imports: [CommonModule , FormsModule],
  templateUrl: './managerlogin.component.html',
  styleUrl: './managerlogin.component.css'
})
export class ManagerloginComponent {
  username: string = 'lovely';
  password: string = 'lovely';

  onSubmit() {
    if (this.username && this.password) {
    
      console.log('Username:', this.username);
      console.log('Password:', this.password);
    }
  }
}
