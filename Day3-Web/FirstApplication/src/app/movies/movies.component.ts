import { Component, OnInit } from '@angular/core';
import { MovieService } from '../services/movieService';
import { Movie } from '../models/movie';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {

  movies:Movie[];
  //movieService:MovieService;
  constructor(private movieService:MovieService ) {
   // this.movieService = new MovieService();
    this.movies = this.movieService.getMovies();
   }

  ngOnInit(): void {
  }

}
