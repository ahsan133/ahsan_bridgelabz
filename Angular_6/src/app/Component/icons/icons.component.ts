import { Component, OnInit, Input } from '@angular/core';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { MatDialog, MatSnackBar } from '@angular/material';
import { NotesService } from 'src/app/Services/notes.service';
import { ImageUploadComponent } from '../image-upload/image-upload.component';
import {DataSharingService} from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-icons',
  templateUrl: './icons.component.html',
  styleUrls: ['./icons.component.scss']
})
export class IconsComponent implements OnInit {
  @Input() data;
  note = [];
  
  image: any;

  constructor(
    private dataSharing:DataSharingService,
    public dialog:MatDialog, 
    private notes:NotesService,
    private snackBar: MatSnackBar) { }


  ngOnInit() {
    this.note=this.data;
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

  AddCollaborator(onenote: any): void{
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px', data:onenote});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  addRemainder8PM(){
this.notes.addRemainder(this.data.id, "Today, 8:00 PM").subscribe((status)=>{
  if (status != null){
    this.dataSharing.changeMessage(true);
    this.snackBar.open('Remainder added.','', {duration: 2000});
  }
    });
  }

  addRemainder8AM(){
    this.notes.addRemainder(this.data.id, "Tomorrow, 8:00 AM").subscribe((status)=>{
      if (status != null){
        this.dataSharing.changeMessage(true);
        this.snackBar.open('Remainder added.','', {duration: 2000});
      }
    });
  }

  addImage(onenote: any): void {
    const dialogRef =this.dialog.open(ImageUploadComponent,{ width: '460px',
    height: '440px' ,  data:onenote});
   
     dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.image =result;
     });
   }

  addArchive(){
    this.notes.addArchive(this.data.id).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeMessage(true);
        this.snackBar.open('Added to archive.','', {duration: 2000});
      }
    });
  }

  removeArchive(){
    this.notes.removeArchive(this.data.id).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeMessage(true);
        this.snackBar.open('Removed from archive.','', {duration: 2000});
      }
    });
  }
  
  addTrash(){
    this.notes.addTrash(this.data.id).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeMessage(true);
        this.snackBar.open('Added to trash.','', {duration: 2000});
      }
    }); 
  }
  
  updatecolor(index){
    this.notes.addColor(this.data.id, this.Colors[index].name).subscribe((status)=>{
      if(status != null){ 
        this.dataSharing.changeMessage(true);
          console.log("color added");
      }
    }); 
  }

   addLabel(){
    
   }
}
