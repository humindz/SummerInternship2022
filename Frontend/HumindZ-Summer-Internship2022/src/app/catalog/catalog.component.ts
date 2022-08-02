import { Component, OnDestroy, OnInit } from "@angular/core";
import { Subscription } from "rxjs";
import { IProduct } from "./Product";
import { MatCardModule } from '@angular/material/card';

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

  produt1 = {
    ProductId: 1,
    ProductName: 'Pelda',
    ProductCategoryType: 'Tipus1',
    ProductShortDescription: 'fkjafj lsa jflsaj flsj alj flsaj f',
    ProductLongDescription: 'kf jsalfj lsa jfka jflsja lsajl fjsal jl',
    ProductVersion: '1.10',
    ProductVersionDate: '2022.08.01',
    ProductVersionNotes: 'None',
    };
    
  filteredProducts: IProduct[] = [{
    ProductId: 'aaa11',
    ProductName: 'Pelda1',
    ProductCategoryType: 'Tipus1',
    ProductShortDescription: 'fkjafj lsa jflsaj flsj alj flsaj f',
    ProductLongDescription: 'kf jsalfj lsa jfka jflsja lsajl fjsal jl',
    ProductVersion: '1.10',
    ProductVersionDate: '2022.08.01',
    ProductVersionNotes: 'None',
  },
  {
    ProductId: 'aaa12',
    ProductName: 'Pelda2',
    ProductCategoryType: 'Tipus2',
    ProductShortDescription: 'fkjafj lsa ffffffffffffjflsaj flsj alj flsaj f',
    ProductLongDescription: 'kf jsalfj lsa jfka jflsja lsajl fjsal jl',
    ProductVersion: '1.10',
    ProductVersionDate: '2022.08.01',
    ProductVersionNotes: 'None',
  },
  {
    ProductId: 'aaa13',
    ProductName: 'Pelda3',
    ProductCategoryType: 'Tipus1',
    ProductShortDescription: 'fkjafj lsa gggggggggggjflsaj flsj alj flsaj f',
    ProductLongDescription: 'kf jsalfj lsa jfka jflsja lsajl fjsal jl',
    ProductVersion: '1.10',
    ProductVersionDate: '2022.08.01',
    ProductVersionNotes: 'None',
  },
  {
    ProductId: 'aaa14',
    ProductName: 'Pelda4',
    ProductCategoryType: 'Tipus3',
    ProductShortDescription: 'fkjafj lsa jflsaj flsj alj flsaj f',
    ProductLongDescription: 'kf jsalfj lsa jfka jflsja lsajl fjsal jl',
    ProductVersion: '1.10',
    ProductVersionDate: '2022.08.01',
    ProductVersionNotes: 'None',
  },
  {
    ProductId: 'aaa11111',
    ProductName: 'Pelda5',
    ProductCategoryType: 'Tipus2',
    ProductShortDescription: 'fkjafj lsa jflsaj flsj alj flsaj f',
    ProductLongDescription: 'kf jsalfj lsa jfka jflsja lsajl fjsal jl',
    ProductVersion: '1.10',
    ProductVersionDate: '2022.08.01',
    ProductVersionNotes: 'None',
  }];
  products: IProduct[] = [];

 
  constructor(
    // private productService: ProductService
    ) {}

  // performFilter(filterBy: string): IProduct[] {
  //   filterBy = filterBy.toLocaleLowerCase();
  //   return this.products.filter((product: IProduct) =>
  //     product.productName.toLocaleLowerCase().includes(filterBy));
  // }



  ngOnInit(): void {
    // this.sub = this.productService.getProducts().subscribe({
    //   next: products => {
    //     this.products = products;
    //     this.filteredProducts = this.products;
    //   },
    //   error: err => this.errorMessage = err
    // });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  
}