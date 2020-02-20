import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
import { FormControl, Validators, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})

export class LoginComponent implements OnInit {
  hide = false;
  LoginForm: FormGroup;

  constructor(public account : AccountService, private router: Router, private snackbar:MatSnackBar) {
  }

  ngOnInit() {
    this.LoginForm = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z0-9]{6,15}')])
    });
  }

  Login(){
    this.account.login(this.LoginForm).subscribe((status:any) =>{
      if(status == "success")
      {
        this.router.navigate(['/dashboard']);
        this.snackbar.open('logged in');
      }else{
        this.snackbar.open('enter valid email and password');
      }
    });
  }
}
