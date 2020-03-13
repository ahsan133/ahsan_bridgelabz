import { Component, OnInit, Inject } from '@angular/core';
import {MatDialogRef, MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';
import { FormControl, FormGroup } from '@angular/forms';
import {DataSharingService} from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {
  CardForm: FormGroup;
  userData=JSON.parse(localStorage.getItem('userData'));
  title1:any;
  description1:any;
  advance;

  constructor(
    private dataSharing:DataSharingService,
    public dialogRef: MatDialogRef<CardComponent>, 
    public dialog:MatDialog, 
    public note: NotesService,
    private snackbar: MatSnackBar, 
    @Inject(MAT_DIALOG_DATA) public onenote: any) { }

  ngOnInit() {
    this.serviceCard();
    this.CardForm= new FormGroup({
      title:new FormControl(),
      description: new FormControl()
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
}

serviceCard(){
  if(this.userData.cardType == "Basic"){
    this.advance = false;
  }
  if(this.userData.cardType == "Advance"){
    this.advance = true;
  }
}
updateNote(){
  if(this.CardForm.value.title === null){
    this.title1 = this.onenote.title;
  }
  else{
    this.title1 = this.CardForm.value.title;
  }

  if(this.CardForm.value.description === null){
    this.description1 = this.onenote.description;
  } else{
    this.description1 = this.CardForm.value.description;
  }
  this.note.updateNote(this.onenote.id, this.title1, this.description1, this.userData.email).subscribe((status)=>{
    if(status != null){
      this.dataSharing.changeMessage(true);
      this.dialogRef.close();
    }
  });
}

}
