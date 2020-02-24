import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  userData=JSON.parse(localStorage.getItem('userData'));
  profilePic = this.userData.profilePicture;
  first = this.userData.firstName;
  last = this.userData.lastName;
  email = this.userData.email;
  constructor(private router:Router, public account: AccountService, public snackbar: MatSnackBar) { }

  ngOnInit() {
  }

  logout(){
    this.account.logout(this.userData.email).subscribe((status:any)=>{
      if (status == "success"){
        this.router.navigate(['/login']);
        this.snackbar.open('logged out')
      }
    });
  }
}
