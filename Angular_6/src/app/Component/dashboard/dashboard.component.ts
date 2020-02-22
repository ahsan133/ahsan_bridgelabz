import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';
import { getEmail} from 'src/app/Component/login/login.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  constructor(private router:Router, public account: AccountService, public Email:getEmail) { }

  ngOnInit() {
  }

profilePic(){
return this.account.ProfilePic(this.Email.email);
}

}
