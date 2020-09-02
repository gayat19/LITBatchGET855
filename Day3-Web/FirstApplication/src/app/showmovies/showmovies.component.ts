import { Component, OnInit } from '@angular/core';
import { MovieService } from '../services/movieService';
import { Movie } from '../models/movie';

@Component({
  selector: 'app-showmovies',
  templateUrl: './showmovies.component.html',
  styleUrls: ['./showmovies.component.css']
})
export class ShowmoviesComponent implements OnInit {
movies:Movie[];
  constructor(private movieService:MovieService) { 
    this.movies = this.movieService.getMovies();
  }

  ngOnInit(): void {
  }

}
