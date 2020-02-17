import { Component, OnInit, Input } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { ActivatedRoute, Router } from '@angular/router';
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

  constructor(public account: AccountService, private route: ActivatedRoute, private router: Router,
     private snackBar: MatSnackBar) {
  
   }

  ngOnInit() {
    this.RegisterForm = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{3,15}')]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{3,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', Validators.required)
    });
  }

  // Registers() {
  //   this.account.register(this.RegisterForm).subscribe((result) => {
  //     this.router.navigate(['/login']);
  //   }, (err) => {
  //     console.log(err);
  //   });
  // }

  GetRegister() {
    this.account.register(this.RegisterForm.value).subscribe((status: any) => {
      if (status.result === true) {
        this.router.navigate(['/login']);
        this.snackBar.open('register successful');
      }
      this.snackBar.open('Something is wrong');
    }
    );
  }
}
