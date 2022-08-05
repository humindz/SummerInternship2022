import { Injectable } from '@angular/core';

import { firstValueFrom } from 'rxjs';

import { ProductDto } from './product-dto.model';

import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';

import { environment } from '../../environments/environment'


@Injectable({
  providedIn: 'root',
})

export class ProductService {


  constructor(private http:HttpClient) {}

  public async GetProducts(): Promise<ProductDto[]> {
   
    return firstValueFrom(
      
      // this.api.login({ userParam: { userName: username, password: password } 
      this.http.get(`${environment.serverUrl}/Product`)
      
    ).then((data: any) => {
      
      return data;
    });

    
  }
}
