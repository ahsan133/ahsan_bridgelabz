import { Component, OnInit } from '@angular/core';
import {MatDialog,} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {

  constructor(public dialog:MatDialog) { }

  ngOnInit() {
  }

  AddCollaborator(): void{
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    })
  }
}
