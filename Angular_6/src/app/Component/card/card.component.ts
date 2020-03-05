import { Component, OnInit, Inject } from '@angular/core';
import {MatDialogRef, MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {
  CardForm: FormGroup;
  userData=JSON.parse(localStorage.getItem('userData'));


  constructor(public dialogRef: MatDialogRef<CardComponent>, public dialog:MatDialog, public note: NotesService,
    private snackbar: MatSnackBar, @Inject(MAT_DIALOG_DATA) public onenote: any) { }

  ngOnInit() {
    this.CardForm= new FormGroup({
      title:new FormControl(),
      description: new FormControl
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
}

AddCollaborator(): void{
  const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

  dialogRef.afterClosed().subscribe(result => {
    console.log('The dialog was closed');
  });
}



}
