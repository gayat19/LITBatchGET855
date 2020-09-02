import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/productService';
import { Product } from '../models/product';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  product:Product;
  msg:string;
  constructor(private productService:ProductService) {
    this.product = new Product();
   }

   addProduct(){
     if(this.productService.addProduct(this.product))
        this.msg = "Product Added!!"
      else
        this.msg = "Some error..."
   }

  ngOnInit(): void {
  }

}
