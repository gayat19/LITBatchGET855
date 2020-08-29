import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent implements OnInit {
toggleStar:boolean;
clsName:string;
  constructor() { 
    this.toggleStar = false;
    this.clsName = "glyphicon glyphicon-star-empty";
  }
  changeStar(){
    this.toggleStar = !this.toggleStar;
    if(this.toggleStar)
        this.clsName = "glyphicon glyphicon-star";
      else
        this.clsName = "glyphicon glyphicon-star-empty";
  }

  ngOnInit(): void {
  }

}
