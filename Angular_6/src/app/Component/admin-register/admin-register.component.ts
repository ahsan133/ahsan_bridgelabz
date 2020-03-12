import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-admin-register',
  templateUrl: './admin-register.component.html',
  styleUrls: ['./admin-register.component.scss']
})
export class AdminRegisterComponent implements OnInit {
  AdminRegisterForm: FormGroup;
  registered = false;
  hide = true;

  constructor(
    public account: AccountService,
    private router: Router, 
    private snackBar: MatSnackBar
  ) { }

  ngOnInit() {
    this.AdminRegisterForm = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{3,15}')]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{3,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z0-9]{6,15}')])
    });
  }

  adminRegister() {
    this.account.adminRegister(this.AdminRegisterForm.value)
    .subscribe((status: any) => {
      if (status == 1) {
        this.router.navigate(['/login']);
        this.snackBar.open('Admin register successful','', {duration: 2000});
      }
      else{
        this.snackBar.open('email already exist.','', {duration: 2000});
      }
    }
    );
  }
}
