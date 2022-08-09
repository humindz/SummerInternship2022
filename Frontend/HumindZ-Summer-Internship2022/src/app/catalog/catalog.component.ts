import { Component, OnDestroy, OnInit } from "@angular/core";
import { Subscription } from "rxjs";
import { IProduct } from "./Product";
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
    
  // filteredProducts: IProduct[] = [];
  products: IProduct[] = [];
  filterString: string = '';

 
  constructor(
    private productService: ProductService
    )
    {
      let btn = document.getElementById("coolButton");
      if (btn!=null)
      btn.addEventListener("click", (e:Event) => this.getTrainingName(4));
    }

    getTrainingName(n:number){
      console.log(n)
   }


  ngOnInit(): void {
     this.productService.GetProducts().then((productDtos)=>{
      this.products = productDtos;
      console.log(this.products);
      console.log(this.products[0].productName);
    });
  }

  filterClicked(): void{
    let buttons = ["Image Recognition", "Prediction", "Product Recommendations", "Preprocessing on Data", "Automate a Process"];
    let currentButton;
    this.filterString = '';
    for (let i = 0; i < 5; i++) {
      currentButton = <HTMLInputElement> document.getElementById(buttons[i]);
      
      if(currentButton.checked)
      {
        if (this.filterString != '')
        {
          this.filterString += '|'+ currentButton.name;
        }
        else{
          this.filterString += currentButton.name;
        }
      }
    
    }
    console.log(this.filterString)

    if (this.filterString == '')
    {
      this.productService.GetProducts().then((productDtos)=>{
        this.products = productDtos;
      });
    }
    else
    {
      this.productService.GetProductsByFilters(this.filterString).then(
        (result) => {
          this.products = result;
          console.log(result);
        }
      );
    }

    
  }


  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  
}

