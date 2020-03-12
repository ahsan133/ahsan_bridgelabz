import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.scss']
})
export class AdminDashboardComponent implements OnInit {
userData = [];
statistics = true;
details = false;

  constructor(
    public account: AccountService,
    public note:NotesService
  ) { }

  ngOnInit() {
    this.getUserList();
    //this.getNotes();
    this.getUsers();
  }

  UserDetails(){
    this.statistics = false;
    this.details = true;
  }
  UserStatistics(){
    this.statistics = true;
    this.details = false;
  }
  getUserList(){
    this.account.getUserList().subscribe((status:any)=>{
      if(status != null){
        this.userData = status;
      }
    });
  }

  getUsers(){

  }

  // getNotes(){
  //   this.note.getNotes()
  // }
  
}
