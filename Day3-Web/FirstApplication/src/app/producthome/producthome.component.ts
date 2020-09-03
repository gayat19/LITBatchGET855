import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/productService';
import { Product } from '../models/product';
import { Router } from '@angular/router';

@Component({
  selector: 'app-producthome',
  templateUrl: './producthome.component.html',
  styleUrls: ['./producthome.component.css']
})
export class ProducthomeComponent implements OnInit {

  products:Product[];
  constructor(private productService:ProductService,private myRouter:Router) { 
    this.products = this.productService.getProducts();
  }

  viewProduct(id){
    console.log(id);
    this.myRouter.navigate(["/allproducts/proddetail",id])
  }
  ngOnInit(): void {
  }

}
