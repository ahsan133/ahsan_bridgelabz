import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';

@Component({
  selector: 'app-service-card',
  templateUrl: './service-card.component.html',
  styleUrls: ['./service-card.component.scss']
})
export class ServiceCardComponent implements OnInit {
  card;
  selected;

  constructor(
    private account:AccountService,
    private router:Router
  ) { }

  ngOnInit() {
  }

  basicCard(){
    this.selected = !this.selected;
    this.card = "Basic";
  }
  advanceCard(){
    this.selected = !this.selected;
    this.card = "Advance";
  }

  next(){
    this.account.SelectCard(this.card);
     this.router.navigate(['/register']);
  }
}
