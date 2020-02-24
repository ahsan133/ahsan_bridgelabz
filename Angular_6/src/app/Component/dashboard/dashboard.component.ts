import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  userData=JSON.parse(localStorage.getItem('userData'));
  profilePic = this.userData.profilePicture;
  constructor(private router:Router, public account: AccountService) { }

  ngOnInit() {
  }

}
