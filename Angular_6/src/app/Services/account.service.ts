import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class AccountService {
  url: string;
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
    Email: data.email,
    Password: data.password
  };
  let headers = new HttpHeaders({
    'Accept': 'application/json'
  });
  return this.http.post(environment.Url + 'api/login', params, {headers:headers});
}

googleLogin(email){
const param = {
  Email:email
};
return this.http.post(environment.Url + 'api/googleLogin', param);
}

facebookLogin(email){
  const param = {
    Email:email
  };
  return this.http.post(environment.Url + 'api/fbLogin', param);
}

 forgot(data){
  const params = {
    "Email": data.email
  };
  let headers = new HttpHeaders({
    'Accept': 'application/json'
  });
  console.log(params);
  return this.http.post(environment.Url + 'api/forgot', params,{headers:headers});
}
}