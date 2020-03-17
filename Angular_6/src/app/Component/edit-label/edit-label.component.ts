import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { NotesService } from 'src/app/Services/notes.service';
import { FormGroup, FormControl } from '@angular/forms';
import { DataSharingService } from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-edit-label',
  templateUrl: './edit-label.component.html',
  styleUrls: ['./edit-label.component.scss']
})
export class EditLabelComponent implements OnInit {
  EditLabelForm:FormGroup;
  userData= JSON.parse(localStorage.getItem('userData'));

  constructor(
    private dataSharing:DataSharingService,
    private snackbar:MatSnackBar,
    private note: NotesService,
    public dialogRef: MatDialogRef<EditLabelComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }

  ngOnInit() {
    this.EditLabelForm = new FormGroup({
      newLabel: new FormControl(),
      CreateLabel: new FormControl()
    });
  }
  onNoClick(): void {
    this.dialogRef.close();
  }

  createLabel(){
    if(this.EditLabelForm.value.CreateLabel != null){
      this.note.createLabel(this.userData.email,this.EditLabelForm.value.CreateLabel).subscribe((status)=>{
        if(status != null){
          this.dataSharing.changeMessage(true);
          this.dataSharing.changeLabel(true);
            console.log("label added");
            this.ngOnInit();
        }
     });  
    }
  }

  updateLabel(oneLabel){
    this.note.updateLabel(oneLabel.id,this.EditLabelForm.value.newLabel).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeLabel(true);
        this.dataSharing.changeMessage(true);
        this.snackbar.open('Updated.','', {duration: 2000});
      }
    });
  }

  deleteLabel(oneLabel){
    this.note.removeLabel(oneLabel.id).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeLabel(true);
        this.dataSharing.changeMessage(true);
        this.snackbar.open('Label Deleted.','', {duration: 2000});
      }
    });
  }
}
