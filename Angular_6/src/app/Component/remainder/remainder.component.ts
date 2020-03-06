import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-remainder',
  templateUrl: './remainder.component.html',
  styleUrls: ['./remainder.component.scss']
})
export class RemainderComponent implements OnInit {
  userData = JSON.parse(localStorage.getItem('userData'));
  message = [];

  constructor(
    private notes: NotesService,
    private snackBar: MatSnackBar) { }

  ngOnInit() {
    this.getRemainder();
  }

  getRemainder(){
    this.notes.getRemainder(this.userData.email).subscribe((status : any)=>{
      if(status != null){
        this.message = status;
      }
      else{
        this.snackBar.open('No remainder to show.','', {duration: 2000});
      }
    });
  }
}
