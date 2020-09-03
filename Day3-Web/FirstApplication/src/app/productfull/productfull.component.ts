import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { Router, ActivatedRoute } from '@angular/router';
import { ProductService } from '../services/productService';

@Component({
  selector: 'app-productfull',
  templateUrl: './productfull.component.html',
  styleUrls: ['./productfull.component.css']
})
export class ProductfullComponent implements OnInit {
product:Product;
  constructor(private activeRoute:ActivatedRoute,private productService:ProductService) { 
    
  }

  ngOnInit(): void {
    var id:number;
    id=this.activeRoute.snapshot.params["pid"];
    this.product = this.productService.getProduct(id);
  }

}
