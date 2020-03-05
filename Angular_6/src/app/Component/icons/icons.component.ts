import { Component, OnInit, Input } from '@angular/core';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { MatDialog, MatSnackBar } from '@angular/material';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-icons',
  templateUrl: './icons.component.html',
  styleUrls: ['./icons.component.scss']
})
export class IconsComponent implements OnInit {
  @Input() data;
  note = [];
  
  constructor(
    public dialog:MatDialog, 
    private notes:NotesService,
    private snackBar: MatSnackBar) { }


  ngOnInit() {
    this.note=this.data;
  }

  AddCollaborator(){
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  addRemainder8PM(){
    var now = new Date();
    var y = now.getFullYear();
    var m = now.getMonth() + 1;
    var d = now.getDate();
    var mm = m < 10 ? '0' + m : m;
    var dd = d < 10 ? '0' + d : d;
    var date = ''+y+'-'+mm+'-'+dd;

this.notes.addRemainder(this.data.id, date+" 20:00:00.0").subscribe((status)=>{
  if (status != null){
    this.snackBar.open('Remainder added.','', {duration: 2000});
  }
    });
  }
  addRemainder8AM(){
    var now = new Date();
    var y = now.getFullYear();
    var m = now.getMonth() + 1;
    var d = now.getDate() + 1;
    var mm = m < 10 ? '0' + m : m;
    var dd = d < 10 ? '0' + d : d;
    var date = ''+y+'-'+mm+'-'+dd;
  
    this.notes.addRemainder(this.data.id, date+" 08:00:00.0").subscribe((status)=>{
      if (status != null){
        this.snackBar.open('Remainder added.','', {duration: 2000});
      }
    });
  }

  addImage(){

  }

  addArchive(){
    this.notes.addArchive(this.data.id).subscribe((status)=>{
      if(status != null){
        this.snackBar.open('Added to archive.','', {duration: 2000});
      }
    }); 
  }
  
  addTrash(){
    this.notes.addTrash(this.data.id).subscribe((status)=>{
      if(status != null){
        this.snackBar.open('Added to trash.','', {duration: 2000});
      }
    }); 
  }
  
  addColor(data : any){
    console.log(data.color);
    this.notes.addColor(this.data.id, data).subscribe((status)=>{
      if(status != null){
          
      }
    }); 
  }
}
