import { Component, OnInit } from '@angular/core';
import {Movie} from '../models/movie';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  movie:Movie;
  constructor() {
    this.movie = new Movie();
   }


   populateMovie(id,name,dur){
     //console.log(id.value+name.value+dur.value);
    this.movie.id = id.value;
    this.movie.name = name.value;
    this.movie.duration = dur.value;
   }
  ngOnInit(): void {
  }

}
