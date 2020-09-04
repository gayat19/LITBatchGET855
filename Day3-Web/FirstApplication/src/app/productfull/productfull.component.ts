import { Component, OnInit, DoCheck } from '@angular/core';
import { Product } from '../models/product';
import { Router, ActivatedRoute } from '@angular/router';
import { ProductService } from '../services/productService';

@Component({
  selector: 'app-productfull',
  templateUrl: './productfull.component.html',
  styleUrls: ['./productfull.component.css']
})
export class ProductfullComponent implements OnInit,DoCheck {
product:Product;
  constructor(private activeRoute:ActivatedRoute,private productService:ProductService) { 
    
  }
  ngDoCheck(): void {
    // var id:number;
    // id=this.activeRoute.snapshot.params["pid"];
    // this.product = this.productService.getProduct(id);
     // this.product = this.productService.getProduct(id);
     var id:number;
     this.activeRoute.params.subscribe((myParam)=>{
       id = myParam["pid"];
       this.product = this.productService.getProduct(id);
     })
  }

  ngOnInit(): void {
    // var id:number;
    // id=this.activeRoute.snapshot.params["pid"];
   
  }

}
