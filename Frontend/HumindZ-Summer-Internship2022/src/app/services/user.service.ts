import { Injectable } from '@angular/core';

import { firstValueFrom } from 'rxjs';

import { UserDto } from './user-dto.model';

import { HttpClient} from '@angular/common/http';

import { environment } from '../../environments/environment'


@Injectable({
  providedIn: 'root',
})



export class UserService {

  constructor(private http:HttpClient) {}  

  public async login(username: string, password: string): Promise<UserDto> {
    let body = JSON.stringify({userName: username, password: password})
    let options = {
      headers: { 'Content-Type': 'application/json' },
    };
    return firstValueFrom(
      
      this.http.post(`${environment.serverUrl}/User/login`,body, options)
      
    ).then((data: any) => {
      console.log(data)
      return data;
    });
  }

}
