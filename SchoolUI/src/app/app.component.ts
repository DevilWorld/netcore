import { Component } from '@angular/core';
import { NgbTabChangeEvent } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

private router: Router;

  onTabChange($event: NgbTabChangeEvent) {
    if ($event.nextId === 'first') {
      this.router.navigateByUrl('/addStudent');
    } else if ($event.nextId === 'second') {
      this.router.navigateByUrl('/addStudent');
    }
  }
}
