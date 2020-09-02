import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-rlogin',
  templateUrl: './rlogin.component.html',
  styleUrls: ['./rlogin.component.css']
})
export class RloginComponent implements OnInit {

myForm:FormGroup;
  constructor() {
    this.myForm = new FormGroup({
      username:new FormControl(null,[Validators.required,Validators.minLength(3),Validators.pattern("[0-9][0-9][0-9]")]),
      password:new FormControl(null,Validators.required)
    });
   }
   get username(){
     return this.myForm.get("username");
   }
   get password(){
     return this.myForm.get("password");
   }
   doLogin(){
     if(this.myForm.valid)
        console.log("Welcome");
      else
        console.log("Some error");
   }
  ngOnInit(): void {
  }

}
