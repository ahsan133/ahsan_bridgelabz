import { Component, OnInit } from '@angular/core';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { MatDialog } from '@angular/material';

@Component({
  selector: 'app-icons',
  templateUrl: './icons.component.html',
  styleUrls: ['./icons.component.scss']
})
export class IconsComponent implements OnInit {

  constructor(public dialog:MatDialog) { }

  ngOnInit() {
  }

  AddCollaborator(){
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}
