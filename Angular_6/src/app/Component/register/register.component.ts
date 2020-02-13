import { Component, OnInit, Input } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  @Input() Data ={firstName:'', lastName:'', email:'', password:''};

  constructor(public account: AccountService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
  }

  addProduct() {
    this.account.addProduct(this.Data).subscribe((result) => {
      this.router.navigate(['/']);
    }, (err) => {
      console.log(err);
    });
  }
}
