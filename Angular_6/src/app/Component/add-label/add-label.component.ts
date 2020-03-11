import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { FormControl, FormGroup } from '@angular/forms';
import { NotesService } from 'src/app/Services/notes.service';
import {DataSharingService} from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-add-label',
  templateUrl: './add-label.component.html',
  styleUrls: ['./add-label.component.scss']
})
export class AddLabelComponent implements OnInit {
  LabelForm:FormGroup;

  constructor( 
    private dataSharing:DataSharingService,
    private notes:NotesService,
    private snackBar: MatSnackBar,
    public dialogRef: MatDialogRef<AddLabelComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit() {
  this.LabelForm = new FormGroup({
    labelInput: new FormControl(),
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  addLabel(){
    if (this.LabelForm.value.labelInput != null){
      this.notes.addLabel(this.data.onenote.email,this.LabelForm.value.labelInput,this.data.onenote.id).subscribe((status)=>{
        if(status != null){
          this.dataSharing.changeMessage(true);
          this.dataSharing.changeLabel(true);
          this.dialogRef.close();
          this.snackBar.open('Label Added.','', {duration: 2000});
        }
      });
    }
  }

  AddLabel1(data){
    this.notes.addLabel(this.data.onenote.email, data.label, this.data.onenote.id).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeMessage(true);
        this.dialogRef.close();
        this.snackBar.open('Label Added.','', {duration: 2000});
      }
    });
  }

}
