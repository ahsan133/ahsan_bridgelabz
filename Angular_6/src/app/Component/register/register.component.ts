import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  
  constructor(public account: AccountService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    
  }
}
