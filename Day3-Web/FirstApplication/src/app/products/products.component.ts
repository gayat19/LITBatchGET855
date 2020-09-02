import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/productService';
import { Product } from '../models/product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products:Product[];
  constructor(private productService:ProductService) {
    this.products = this.productService.getProducts();
   }

buy(id){
  let product = this.productService.getProduct(id);
  let myProduct = new Product();
  myProduct.id = product.id;
  myProduct.name = product.name;
  myProduct.price = product.price;
  myProduct.img = product.img;
  myProduct.quantity = 1;
  this.productService.addToCart(myProduct);
}

  ngOnInit(): void {
  }

}
