import { Component, OnInit } from '@angular/core';
import { MovieService } from '../services/movieService';
import { Movie } from '../models/movie';

@Component({
  selector: 'app-selectmovie',
  templateUrl: './selectmovie.component.html',
  styleUrls: ['./selectmovie.component.css']
})
export class SelectmovieComponent implements OnInit {

  movies:Movie[];
  movie:Movie;
  constructor(private movieService:MovieService) { 
    this.movies = this.movieService.getMovies();
  }

  changeMovie(id){
    this.movie = this.movieService.getMovie(id.value);
  }

  ngOnInit(): void {
  }

}
