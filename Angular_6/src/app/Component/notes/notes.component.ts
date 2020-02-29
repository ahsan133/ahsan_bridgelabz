import { Component, OnInit } from '@angular/core';
import {MatDialog,} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import {CardComponent} from 'src/app/Component/card/card.component';


@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {

  constructor(public dialog:MatDialog) { }

  ngOnInit() {
  }

  cardOpen(): void{
    const dialogRef =this.dialog.open(CardComponent ,{ width: '500px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    })
  }


  AddCollaborator(): void{
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    })
  }
}
