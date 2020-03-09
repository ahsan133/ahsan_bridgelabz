import { Component, OnInit, ViewChild } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-labels',
  templateUrl: './labels.component.html',
  styleUrls: ['./labels.component.scss']
})
export class LabelsComponent implements OnInit {
  userData=JSON.parse(localStorage.getItem('userData'));
  labels =[];

  constructor(
    private note:NotesService
  ) { }

  ngOnInit() {
    this.getLabel();
  }

  getLabel(){
   this.note.getLabel(this.userData.email).subscribe((status:any)=>{
     if(status != null){
       console.log(status);
       this.labels = status;
     }
   });
  }
}
