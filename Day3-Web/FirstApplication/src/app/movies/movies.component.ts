import { Component, OnInit } from '@angular/core';
import { MovieService } from '../services/movieService';
import { Movie } from '../models/movie';
import { Router } from '@angular/router';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {

  movies:Movie[];
  //movieService:MovieService;
  constructor(private movieService:MovieService,private myRouter:Router ) {
   // this.movieService = new MovieService();
    this.movies = this.movieService.getMovies();
   }
   goToStar(){
      this.myRouter.navigate(['star']);
   }
  ngOnInit(): void {
  }

}
