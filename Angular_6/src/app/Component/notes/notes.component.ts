import { Component, OnInit, ViewChild } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';
import {DataSharingService} from 'src/app/Services/data-sharing.service';
import { IconComponent } from '../icon/icon.component';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {
  userData=JSON.parse(localStorage.getItem('userData'));
  color= "#FFFFFF";
  archive=false;
  remainder=null;
  title;
  description;
  card1 = true;
  card2 = false;
  advance: boolean;

  constructor(
    private dataSharing:DataSharingService,
    private notes:NotesService,  
    private snackbar: MatSnackBar) { }

  ngOnInit() {
    this.serviceCard();
    // this.change(this.color, this.archive, this.remainder);

    this.dataSharing.currentMessage.subscribe((change) =>{
      if(change == true){
        this.change(color,archive,remainder);
        this.ngOnInit();
        this.dataSharing.changeMessage(false);
      }
      }); 
  }

  change(color,archive,remainder){
    this.color =  color;
    this.archive = archive;
    this.remainder = remainder;
  }
  
  serviceCard(){
    if(this.userData.cardType == "Basic"){
      this.advance = false;
    }
    if(this.userData.cardType == "Advance"){
      this.advance = true;
    }
    }

  note(){
    this.card2=true;
    this.card1=false;
  }
  
  close(){
    this.card1 = true;
    this.card2 = false;
    if(this.title != null || this.description !=null){
      this.notes.addNote(this.title ,this.description,this.userData.email).subscribe((status)=>{
        if(status != null){
          localStorage.setItem('noteData', JSON.stringify(status));
          this.dataSharing.changeMessage(true);
          this.snackbar.open('Note added.','', {duration: 2000});
        }
      });
    }
  }
}
