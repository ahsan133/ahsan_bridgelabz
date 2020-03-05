import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
import { FormControl, Validators, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-forgot',
  templateUrl: './forgot.component.html',
  styleUrls: ['./forgot.component.scss']
})
export class ForgotComponent implements OnInit {
  ForgotForm: FormGroup;


  constructor(public account: AccountService, private router: Router, private snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.ForgotForm=new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email])
    });
    
  }

async Forgot(){
    await this.account.forgot(this.ForgotForm.value).subscribe((status) => {
   if(status == "success")
   {
     this.router.navigate(['/login']);
     this.snackBar.open('check email for new passsword','', {duration: 2000});
   }else{
     console.log("error while processing the request")
     this.snackBar.open('invalid email','', {duration: 2000});
   }
  });
}
}
