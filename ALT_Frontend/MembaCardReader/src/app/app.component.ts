import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UserViewComponent } from './user-view/user-view.component';
import { UserListComponent } from './user-list/user-list.component';
import { SerialDetailsComponent } from './serial-details/serial-details.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,UserViewComponent,UserListComponent,SerialDetailsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'MembaCardReader';
}
