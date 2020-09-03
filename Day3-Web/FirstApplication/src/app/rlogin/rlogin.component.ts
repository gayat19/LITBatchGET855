import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-rlogin',
  templateUrl: './rlogin.component.html',
  styleUrls: ['./rlogin.component.css']
})
export class RloginComponent implements OnInit {

myForm:FormGroup;
err:string;
  constructor(private userRouter:Router) {
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
     {
        if(this.username.value =="123" && this.password.value=="123")
          this.userRouter.navigate(['userhome']);
        else
          this.err="Invalid username or password"
     }
   }
  ngOnInit(): void {
  }

}
