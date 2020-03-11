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

  constructor(
    private dataSharing:DataSharingService,
    private snackbar:MatSnackBar,
    private note: NotesService,
    public dialogRef: MatDialogRef<EditLabelComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }

  ngOnInit() {
    this.EditLabelForm = new FormGroup({
      newLabel: new FormControl()
    });
  }
  onNoClick(): void {
    this.dialogRef.close();
  }

  updateLabel(oneLabel){
    this.note.updateLabel(oneLabel.id,this.EditLabelForm.value.newLabel).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeLabel(true);
        this.dataSharing.changeMessage(true);
        console.log("done");
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
