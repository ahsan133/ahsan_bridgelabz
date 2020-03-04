import { Component, OnInit, Inject } from '@angular/core';
import {MatDialogRef, MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {
  userData=JSON.parse(localStorage.getItem('userData'));
  title;
  description;
  image;

  constructor(public dialogRef: MatDialogRef<CardComponent>, public dialog:MatDialog, public note: NotesService,
    private snackbar: MatSnackBar, @Inject(MAT_DIALOG_DATA) public onenote: any) { }

  ngOnInit() {
  }

  onNoClick(): void {
    this.addNote();
    this.dialogRef.close();
}

AddCollaborator(): void{
  const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

  dialogRef.afterClosed().subscribe(result => {
    this.addNote();
    console.log('The dialog was closed');
  });
}

addNote(){
  if(this.title != null || this.description !=null){
    this.note.addNote(this.title ,this.description,this.userData.email).subscribe((status)=>{
      if(status != null){
        localStorage.setItem('noteData', JSON.stringify(status));
        this.snackbar.open('Note added.','', {duration: 2000});
      }
    });
  }
}


}
