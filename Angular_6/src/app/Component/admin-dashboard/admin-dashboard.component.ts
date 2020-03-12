import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { NotesService } from 'src/app/Services/notes.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.scss']
})
export class AdminDashboardComponent implements OnInit {
userData = [];
usersData = [];
notes = [];
statistics = true;
details = false;
count;

  constructor(
    public account: AccountService,
    public note:NotesService,
    public router:Router
  ) { }

  ngOnInit() {
    this.getUserList();
    this.getNotes();
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
    this.account.getUsers().subscribe((status:any)=>{
      if(status != null){
        this.usersData = status;
      }
    });
  }

  getNotes(){
     this.note.getNotesList().subscribe((status:any)=>{
      if(status != null){
        this.notes = status;
        console.log(status);
      }
    });
   }
  
   countNotes(email){
     this.count=0;
     for(let i of this.notes){
       if(i.email == email){
         this.count = this.count+1
       }
     }
   }

   logout(){
     this.router.navigate(['/login']);
   }
}
