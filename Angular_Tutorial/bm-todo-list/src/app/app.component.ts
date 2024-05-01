import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'bm-todo-list';
  heading = 'need to add';
  name = '';
  clickMessage = '';

  onClickMe() {
    this.clickMessage = 'I am from angular!';
  }
  onCWrite() {
    this.name = '';
  }
}
