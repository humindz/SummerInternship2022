import { Component, OnDestroy, OnInit } from "@angular/core";
import { Subscription } from "rxjs";
import { IProduct } from "./Product";
import { MatCardModule } from '@angular/material/card';
import { ProductService } from '../services/product.service'

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.scss']
})
export class CatalogComponent implements OnInit, OnDestroy {
  
  pageTitle = 'Catalog';
  pageSubTitle = 'View our entire offering of scripts.'
  
  errorMessage = '';
  sub!: Subscription;

  private _listFilter = '';

  // get listFilter(): string {
  //   return this._listFilter;
  // }

  // set listFilter(value: string) {
  //   this._listFilter = value;
  //   this.filteredProducts = this.performFilter(value);
  // }


    
  filteredProducts: IProduct[] = [];
  products: IProduct[] = [];

 
  constructor(
    private productService: ProductService
    ) {}

  // performFilter(filterBy: string): IProduct[] {
  //   filterBy = filterBy.toLocaleLowerCase();
  //   return this.products.filter((product: IProduct) =>
  //     product.productName.toLocaleLowerCase().includes(filterBy));
  // }



  ngOnInit(): void {
     this.productService.GetProducts().then((productDtos)=>{
      this.filteredProducts = productDtos;
      this.products = productDtos;
      console.log(this.products);
      console.log(this.products[0].productName);
    });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  
}