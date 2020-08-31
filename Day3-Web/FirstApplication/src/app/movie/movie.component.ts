import { Component, OnInit } from '@angular/core';
import {Movie} from '../models/movie';
import { MovieService } from '../services/movieService';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  movie:Movie;
  //movieService:MovieService;
  constructor(private movieService:MovieService) {
    this.movie = new Movie();
    //this.movieService = new MovieService();
   }


   populateMovie(id,name,dur){
     //console.log(id.value+name.value+dur.value);
    this.movie.id = id.value;
    this.movie.name = name.value;
    this.movie.duration = dur.value;
   }
  ngOnInit(): void {
  }
  addMovie(){
    this.movieService.addMovie(this.movie);
    this.movie = new Movie();
  }

}
