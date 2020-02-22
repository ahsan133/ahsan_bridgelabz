import { Component, OnInit, Input} from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
import { FormControl, Validators, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { GoogleLoginProvider, FacebookLoginProvider, AuthService } from 'angular-6-social-login';   

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})

export class LoginComponent implements OnInit {
  hide = true;
  LoginForm: FormGroup;

  constructor(public account : AccountService, private router: Router, private snackbar:MatSnackBar, public socialAuthService: AuthService) {
  }

  ngOnInit() {
    this.LoginForm = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z0-9]{6,15}')])
    });
  }

  Login(){
    this.account.login(this.LoginForm.value).subscribe((status:any) =>{
      if(status == "success")
      {
        this.router.navigate(['/dashboard']);
        this.snackbar.open('logged in');
      }else{
        this.snackbar.open('enter valid email and password');
      }
    });
  }

  Google(){
    let socialPlatformProvider;
    socialPlatformProvider = GoogleLoginProvider.PROVIDER_ID;
    this.socialAuthService.signIn(socialPlatformProvider).then((userData) => {
      this.account.googleLogin(userData.email).subscribe((status: any) => {
        if (status != null) {
          localStorage.setItem('userData', JSON.stringify(status));
          this.router.navigate(['/dashboard']);
          this.snackbar.open('logged in');
        }else{
        this.snackbar.open('Invalid Email or Password');
        }
      }
      );
    }).catch((err) => {
      console.log('error in google sign in', err);
    });
  }

  Facebook(){
    let socialPlatformProvider;
    socialPlatformProvider = FacebookLoginProvider.PROVIDER_ID;
    this.socialAuthService.signIn(socialPlatformProvider).then((userData) => {
      this.account.facebookLogin(userData.email).subscribe((status: any) => {
        if (status != null) {
          localStorage.setItem('userData', JSON.stringify(status));
          this.router.navigate(['/dashboard']);
          this.snackbar.open('logged in');
        }else{
        this.snackbar.open('Invalid Email or Password');
        }
      }
      );
    }).catch((err) => {
      console.log('error in FB sign in', err);
    });
  }
}

export class getEmail {
  LoginForm = new FormGroup({
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z0-9]{6,15}')])
  });
  email = this.LoginForm.value;
}