import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/productService';
import { Product } from '../models/product';

@Component({
  selector: 'app-showproducts',
  templateUrl: './showproducts.component.html',
  styleUrls: ['./showproducts.component.css']
})
export class ShowproductsComponent implements OnInit {

  products:Product[];
  constructor(private productService:ProductService) {
    this.products = this.productService.getProducts();
   }

  ngOnInit(): void {
  }

}
