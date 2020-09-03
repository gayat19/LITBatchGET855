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
import { ShowproductComponent } from './showproduct/showproduct.component';
import { ShowproductsComponent } from './showproducts/showproducts.component';
import { ExplainEventsComponent } from './explain-events/explain-events.component';
import { SampleParentComponent } from './sample-parent/sample-parent.component';
import { Routes,RouterModule } from '@angular/router';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { HomeComponent } from './home/home.component';
import { ProducthomeComponent } from './producthome/producthome.component';
import { ProductfullComponent } from './productfull/productfull.component';


var myRoutes:Routes=[
  {path:'products',component:ProductsComponent},
  {path:'movies',component:MoviesComponent},
  {path:'star',component:StarComponent},
  {path:'userhome',component:HomeComponent,children:[
    {path:'products',component:ProductsComponent},
    {path:'cart',component:CartComponent},
    {path:'addproduct',component:AddProductComponent}
  ]},
  {path:'login',component:RloginComponent},
  {path:'allproducts',component:ProducthomeComponent,children:[
    {path:'proddetail/:pid',component:ProductfullComponent}
  ]},
  {path:'**',component:PagenotfoundComponent}//wildcard based routing
]


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
    SelectmovieComponent,
    ShowproductComponent,
    ShowproductsComponent,
    ExplainEventsComponent,
    SampleParentComponent,
    PagenotfoundComponent,
    HomeComponent,
    ProducthomeComponent,
    ProductfullComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(myRoutes)
  ],
  providers: [MovieService,ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
