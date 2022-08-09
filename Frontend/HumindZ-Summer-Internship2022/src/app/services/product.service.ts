import { Injectable } from '@angular/core';

import { firstValueFrom } from 'rxjs';

import { ProductDto } from './product-dto.model';

import { HttpClient} from '@angular/common/http';

import { environment } from '../../environments/environment'


@Injectable({
  providedIn: 'root',
})

export class ProductService {


  constructor(private http:HttpClient) {}

  public async GetProducts(): Promise<ProductDto[]> {
   
    return firstValueFrom(

      this.http.get(`${environment.serverUrl}/Product`)
      
    ).then((data: any) => {
      return data;
    });
  }

  public async GetProductsByFilters(filters: string): Promise<ProductDto[]> {
   
    return firstValueFrom(

      this.http.get(`${environment.serverUrl}/Product/filtered?filter=${filters}`)
      
    ).then((data: any) => {
      return data;
    });
  }

}
