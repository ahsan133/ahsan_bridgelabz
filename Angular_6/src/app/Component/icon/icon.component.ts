import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { NotesService } from 'src/app/Services/notes.service';
import { DataSharingService } from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-icon',
  templateUrl: './icon.component.html',
  styleUrls: ['./icon.component.scss']
})
export class IconComponent implements OnInit {
color = "#FFFFFF";
archive=false;
remainder=null;

  constructor(
    private dataSharing:DataSharingService,
    private note:NotesService,
    private snackBar:MatSnackBar
  ) { }

  ngOnInit() {
    this.sendData();


  }
sendData(){
  this.note.sendData(this.archive,this.color, this.remainder);
  
}

  Colors =[
    {colorCode:'#FFFFFF',name:'white'},
    {colorCode:'#FF0000',name:'red'},
    {colorCode:'#FFA500',name:'orange'},
    {colorCode:'#008000', name:'green'},
    {colorCode:'#FFFF00',name:'yellow'},
    {colorCode:'#808080',name:'gray'},
    {colorCode:'#800080',name:'purple'},
    {colorCode:'#FFC0CB',name:'pink'},
    {colorCode:'#A52A2A',name:'brown'},
    {colorCode:'#4b0082',name:'indigo'},
    {colorCode:'#008080',name:'teal'}
  ];


  addRemainder8PM(){
    this.remainder ="Today, 8:00 PM";
    this.sendData();
    }
    
  addRemainder8AM(){
      this.remainder = "Tomorrow, 8:00 AM";
      this.sendData();
    }

  addArchive(){
    this.archive=true;
    this.sendData();
  }
  removeArchive(){
    this.archive=false;
    this.sendData();
  }
  addImage(){

  }
  updatecolor(i){
    this.color =this.Colors[i].colorCode;
    this.sendData();
    this.dataSharing.changeData(this.color);
  }
}
