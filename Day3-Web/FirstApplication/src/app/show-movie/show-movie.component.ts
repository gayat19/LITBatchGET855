import { Component, OnInit } from '@angular/core';
import { MovieService } from '../services/movieService';
import { Movie } from '../models/movie';

@Component({
  selector: 'app-show-movie',
  templateUrl: './show-movie.component.html',
  styleUrls: ['./show-movie.component.css']
})
export class ShowMovieComponent implements OnInit {

  movies:Movie[];
  movie:Movie;
  constructor(private movieService:MovieService) { 
    this.movies = this.movieService.getMovies();
  }


  showMovie(id){
    //if(id.value != "Select Movie")
      this.movie = this.movieService.getMovie(id.value);
  
  }
  ngOnInit(): void {
  }

}
