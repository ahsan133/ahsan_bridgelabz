import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, NgForm } from '@angular/forms';
import { AccountService } from 'src/app/account.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})

export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  constructor() {
    this.loginForm = new FormGroup({
      email : new FormControl(),
      password : new FormControl()
    });
  }

  ngOnInit() {}

   login(form: NgForm) {
   this.service.getLogin(this.loginForm.value).subscribe((status: any) => {
    if (status != null) {
      localStorage.setItem('userData', JSON.stringify(status));
      this.route.navigate(['']);
    } else {
       this.snackBar.open('invalid');
    }
   });
  }
}
