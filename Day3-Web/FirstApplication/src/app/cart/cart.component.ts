import { Component, OnInit, OnChanges, SimpleChanges, DoCheck } from '@angular/core';
import { ProductService } from '../services/productService';
import { Product } from '../models/product';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit,DoCheck {

  products:Product[];
  grandTotal:number;
  constructor(private productService:ProductService) {
    this.products = this.productService.cart;
    this.grandTotal =0;
    
   }
  ngDoCheck(): void {
    this.grandTotal=0;
    //console.log(this.products)
    this.products.forEach(element => {
      this.grandTotal += element.price*element.quantity;
    });
  }

  ngOnInit(): void {
  }

}
