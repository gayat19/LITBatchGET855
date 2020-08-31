import {Movie} from '../models/movie';

export class MovieService{
movies:Movie[];

constructor(){
    this.movies = [
        new Movie(101,"Harry Potter - Part 1",123.1),
        new Movie(102,"MI2",100.7),
        new Movie(103,"Death Race",165.2),
        new Movie(104,"How to train your dragon",111.8)
    ];
}

addMovie(movie:Movie):boolean{
    for (let index = 0; index < this.movies.length; index++) {
        if(this.movies[index].id == movie.id)
        {
            return false;
        }  
    }
    this.movies.push(movie);
    return true;
}

getMovies():Movie[]{
    return this.movies;
}

getMovie(id:number):Movie{
        for (let index = 0; index < this.movies.length; index++) {
            if(this.movies[index].id == id)
            {
                return this.movies[index];
            } 
        }
        return null; 
    }
}