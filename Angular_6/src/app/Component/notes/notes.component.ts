import { Component, OnInit } from '@angular/core';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import {CardComponent} from 'src/app/Component/card/card.component';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {
  userData=JSON.parse(localStorage.getItem('userData'));

  title;
  description;
  card1 = true;
  card2 = false;
  constructor(private notes:NotesService,  private snackbar: MatSnackBar) { }

  ngOnInit() {
  }

  note(){
    this.card2=true;
    this.card1=false;
  }
  
  close(){
    this.card1 = true;
    this.card2 = false;
    if(this.title != null || this.description !=null){
      this.notes.addNote(this.title ,this.description,this.userData.email).subscribe((status)=>{
        if(status != null){
          localStorage.setItem('noteData', JSON.stringify(status));
          this.snackbar.open('Note added.','', {duration: 2000});
        }
      });
    }
  }
}
