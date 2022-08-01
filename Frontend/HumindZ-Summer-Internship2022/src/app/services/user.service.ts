import { Injectable } from '@angular/core';

import { firstValueFrom } from 'rxjs';

import { UserDto } from './user-dto.model';

import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';

import { environment } from '../../environments/environment'


@Injectable({
  providedIn: 'root',
})



export class UserService {

  // readonly options: APIHttpOptions;

  constructor(private http:HttpClient) {}


  public async login(username: string, password: string): Promise<UserDto> {
    let body = JSON.stringify({userName: username, password: password})
    return firstValueFrom(
      // this.api.login({ userParam: { userName: username, password: password } 
      this.http.post(`${environment.serverUrl}/User/login`,body)
      
    ).then((data: any) => {
      console.log(data)
      return data;
    });
  }

}
