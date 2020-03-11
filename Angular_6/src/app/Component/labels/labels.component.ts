import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-labels',
  templateUrl: './labels.component.html',
  styleUrls: ['./labels.component.scss']
})
export class LabelsComponent implements OnInit {
  userData=JSON.parse(localStorage.getItem('userData'));
  label =[];
  @Output() messageEvent = new EventEmitter<any>();
  @Input() data;

  constructor(
    private snackBar:MatSnackBar,
    private note:NotesService
  ) { }

  ngOnInit() {
    this.getLabel();
    this.messageEvent.emit(this.label)
  }

  getLabel(){
   this.note.getLabel(this.userData.email).subscribe((status:any)=>{
     if(status != null){
       this.label = status;
     }
   });
  }

  removeLabel(oneLabel : any){
    this.note.removeLabel(oneLabel.id).subscribe((status : any)=>{
      if(status != null){
        this.getLabel();
        this.snackBar.open('Label Removed.','', {duration: 2000});
      }
    });
  }
}
