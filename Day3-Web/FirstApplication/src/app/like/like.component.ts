import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-like',
  templateUrl: './like.component.html',
  styleUrls: ['./like.component.css']
})
export class LikeComponent implements OnInit {
  count:number;
  constructor() { 
    this.count=0;
  }

  ngOnInit(): void {
   
  }
  incCount(){
    this.count+=1;
  }
}
