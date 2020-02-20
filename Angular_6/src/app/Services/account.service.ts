import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class AccountService {
  constructor(private http: HttpClient) { }

 register(data) {
  const params = {
    FirstName: data.firstName,
    LastName: data.lastName,
    Email: data.email,
    Password: data.password
  };
  return this.http.post(environment.Url + 'api/register/', params);
}

login(data){
  const params = {
    Email: data.value.email,
    Password: data.value.password
  };
  console.log(params);
  return this.http.post(environment.Url + 'api/login/', params);
}
}
