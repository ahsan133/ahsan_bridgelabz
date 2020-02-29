import { Component, OnInit } from '@angular/core';
import {MatDialogRef, MatDialog} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<CardComponent>, public dialog:MatDialog) { }

  ngOnInit() {
  }

  onNoClick(): void {
    this.dialogRef.close();
}

AddCollaborator(): void{
  const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

  dialogRef.afterClosed().subscribe(result => {
    console.log('The dialog was closed');
  })
}

}
