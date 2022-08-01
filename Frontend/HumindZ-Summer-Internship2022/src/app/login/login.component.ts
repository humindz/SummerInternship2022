import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(
    private readonly userService: UserService,
    private router: Router
  ) {}

  ngOnInit(): void {
  }

  
  onSubmit() { 
    let userName = (<HTMLInputElement>document.getElementById("username")).value;
    let userPassword = (<HTMLInputElement>document.getElementById("password")).value;
    console.log(userName, userPassword);
    console.log('haha')

    this.userService.login(userName, userPassword);//.then();

  }
}
