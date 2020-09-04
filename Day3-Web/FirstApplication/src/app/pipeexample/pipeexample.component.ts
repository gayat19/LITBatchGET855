import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipeexample',
  templateUrl: './pipeexample.component.html',
  styleUrls: ['./pipeexample.component.css']
})
export class PipeexampleComponent implements OnInit {

  person:any;
  constructor() {
    this. person = {
     id:101,
     name:'Ramu',
     salary:20000
    }
    
   }

  ngOnInit(): void {
  }

}
