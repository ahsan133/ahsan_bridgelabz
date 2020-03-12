 import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import 'rxjs/add/operator/map';

@Injectable({
  providedIn: 'root'
})

export class AccountService {
  url: string;
  constructor(private http: HttpClient) { }

  adminRegister(data){
    const params = {
      FirstName: data.firstName,
      LastName: data.lastName,
      Email: data.email,
      Password: data.password
    };
    return this.http.post(environment.Url + 'api/addAdmin', params);
  }

  AdminLogin(data){
    const params = {
      Email: data.email,
      Password: data.password
    };
    let headers = new HttpHeaders({
      'Accept': 'application/json'
    });
    return this.http.post(environment.Url + 'api/loginAdmin', params, {headers:headers});
  }
  getUserList(){
     return this.http.get(environment.Url + 'api/getUserList');
  }

  getUsers(){
    return this.http.get(environment.Url + 'api/getUsers');
  }
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
  return this.http.post(environment.Url + 'api/forgot', params,{headers:headers});
}

logout(email){
  let headers = new HttpHeaders({
    'Accept': 'application/json'
  });
return this.http.put(environment.Url +'api/logout?email=' + email, null,{headers:headers});
}

uploadProfilePicture(email,file: any) {
  let input = new FormData();
  input.append("image", file);

  return this.http.put(environment.Url + 'api/profilePic?email=' + email, input);
}

}