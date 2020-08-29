import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-second',
  templateUrl: './second.component.html',
  styleUrls: ['./second.component.css']
})
export class SecondComponent implements OnInit {
name:string;
clsName:string;
divClass:string;
check:boolean;
  constructor() { 
    this.name = "Ramu";
    this.clsName = "error";
    this.divClass = "alert";
    this.check = false;
  }
  changeClass(){
    this.check = !this.check;
    if(this.check == false)
      this.divClass = "alert alert-danger";
    else
      this.divClass = "alert alert-info";
  }
  ngOnInit(): void {
  }

}
