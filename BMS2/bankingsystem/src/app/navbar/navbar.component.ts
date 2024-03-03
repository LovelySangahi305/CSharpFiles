import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  constructor(private router: Router) {}
  logout() {
    // Perform any logout logic (e.g., clear session, token, etc.)
    // Then navigate to the home page
    this.router.navigate(['/homepage']);
  }
}
