import { Component, OnInit } from '@angular/core';
import {User} from '../models/user';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
user:User;
  constructor() { 
    this.user = new  User();
  }
  doLogin(un){
    console.log(un);
  }
  ngOnInit(): void {
  }

}
