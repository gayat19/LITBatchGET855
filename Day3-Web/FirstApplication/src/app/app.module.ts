import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {SampleComponent} from './sample/sample.component';
import { SecondComponent } from './second/second.component';
import { StarComponent } from './star/star.component';
import { LikeComponent } from './like/like.component';
import { MovieComponent } from './movie/movie.component';
import { MoviesComponent } from './movies/movies.component';
import { MovieService } from './services/movieService';
import {ProductService} from './services/productService';
import { ShowMovieComponent } from './show-movie/show-movie.component';
import { ProductsComponent } from './products/products.component';
import { CartComponent } from './cart/cart.component';
import { AddProductComponent } from './add-product/add-product.component';
import { LoginComponent } from './login/login.component';
import { RloginComponent } from './rlogin/rlogin.component';
import { ShowmovieComponent } from './showmovie/showmovie.component';
import { ShowmoviesComponent } from './showmovies/showmovies.component';
import { SelectmovieComponent } from './selectmovie/selectmovie.component';

@NgModule({
  declarations: [
    AppComponent,
    SampleComponent,
    SecondComponent,
    StarComponent,
    LikeComponent,
    MovieComponent,
    MoviesComponent,
    ShowMovieComponent,
    ProductsComponent,
    CartComponent,
    AddProductComponent,
    LoginComponent,
    RloginComponent,
    ShowmovieComponent,
    ShowmoviesComponent,
    SelectmovieComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [MovieService,ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
