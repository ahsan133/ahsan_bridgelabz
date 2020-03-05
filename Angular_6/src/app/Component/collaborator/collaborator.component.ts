import { Component, OnInit, Inject } from '@angular/core';
import {MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { NotesService } from 'src/app/Services/notes.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-collaborator',
  templateUrl: './collaborator.component.html',
  styleUrls: ['./collaborator.component.scss']
})
export class CollaboratorComponent implements OnInit {
  userData=JSON.parse(localStorage.getItem('userData'));
  profilePic = this.userData.profilePicture;
  first = this.userData.firstName;
  last = this.userData.lastName;
  email = this.userData.email;
  CollaboratorForm: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<CollaboratorComponent>,
    private note:NotesService,
    public snackBar :MatSnackBar,
    @Inject(MAT_DIALOG_DATA) public onenote: any
    ) { }

  ngOnInit() {
    this.CollaboratorForm = new FormGroup({
        "receiverEmail": new FormControl('',[Validators.required, Validators.email])
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
}

addCollaborator(){
  if (this.CollaboratorForm.value.receiverEmail != null){
    this.note.addCollaborator(this.email,this.CollaboratorForm.value,this.onenote.id).subscribe((status)=>{
      if(status != null){
        this.snackBar.open('Collaborated.','', {duration: 2000});
        this.dialogRef.close();
      }
        });
      }
  }
}