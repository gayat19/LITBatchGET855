import {Product} from '../models/product';


export class ProductService{
products:Product[];
cart:Product[];
constructor(){
    this.products = [
        new Product(101,"Pencil",10,10,"assets/101.jpg"),
        new Product(102,"Pen",20,5,"assets/102.jpg"),
        new Product(103,"Eraser",5,7,"assets/103.jpg")
    ]
    this.cart=[];
}
getProducts():Product[]{
    return this.products;
}

getProduct(id:number):Product{
    for (let index = 0; index < this.products.length; index++) {
        if(this.products[index].id == id)
        {
            return this.products[index];
        } 
    }
    return null; 
}

addProduct(product:Product){
    for (let index = 0; index < this.products.length; index++) {
        if(this.products[index].id == product.id)
        {
            return false;
        }  
    }
    this.products.push(product);
    return true;
}

addToCart(product:Product){
    let flag=0;
    for (let index = 0; index < this.cart.length; index++) {
        if(this.cart[index].id == product.id)
        {
           flag = 1;
           this.cart[index].quantity++;
           break;
        }  
    }
    if(flag ==0)
        this.cart.push(product);
    for (let index = 0; index < this.products.length; index++) {
        if(this.products[index].id == product.id)
        {
            this.products[index].quantity--;
        }  
    }
}


}