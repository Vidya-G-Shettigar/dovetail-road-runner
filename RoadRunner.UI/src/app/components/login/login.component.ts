import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  ngAfterViewInit() {
    document.querySelector('body').classList.add('login');
  }

  ngOnDestroy() {
    document.querySelector('body').classList.remove('login');
  }
}
