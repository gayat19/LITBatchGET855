import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {SampleComponent} from './sample/sample.component';
import { SecondComponent } from './second/second.component';
import { StarComponent } from './star/star.component';
import { LikeComponent } from './like/like.component';
import { MovieComponent } from './movie/movie.component';
import { MoviesComponent } from './movies/movies.component';
import { MovieService } from './services/movieService';
import { ShowMovieComponent } from './show-movie/show-movie.component';

@NgModule({
  declarations: [
    AppComponent,
    SampleComponent,
    SecondComponent,
    StarComponent,
    LikeComponent,
    MovieComponent,
    MoviesComponent,
    ShowMovieComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [MovieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
