import { Component, OnInit } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import {CardComponent} from 'src/app/Component/card/card.component';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {
  noteData =JSON.parse(localStorage.getItem('noteData'));

  constructor(public dialog:MatDialog, private note :NotesService) { }

  ngOnInit() {
  }

  cardOpen(): void{
    const dialogRef =this.dialog.open(CardComponent,{ width: '500px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  AddCollaborator(){
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
  
}
