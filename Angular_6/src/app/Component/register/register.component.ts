import { Component, OnInit, Input } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
import { FormControl, Validators, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  RegisterForm: FormGroup;
  registered = false;
  hide = false;

  constructor(public account: AccountService, private router: Router, private snackBar: MatSnackBar) {}
   
  ngOnInit() {
    this.RegisterForm = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{3,15}')]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{3,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z0-9]{6,15}')])
    });
  }

   Register() {
    this.account.register(this.RegisterForm.value).subscribe((status: any) => {
      if (status == 1) {
        this.router.navigate(['/login']);
        this.snackBar.open('register successful');
      }
      else{
        this.snackBar.open('email already exist.');
      }
    }
    );
  }
}
