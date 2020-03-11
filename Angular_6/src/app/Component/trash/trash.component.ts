import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';
import { DataSharingService } from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-trash',
  templateUrl: './trash.component.html',
  styleUrls: ['./trash.component.scss']
})
export class TrashComponent implements OnInit {
 userData = JSON.parse(localStorage.getItem('userData'));
 message = [];
 change :boolean;
  constructor( 
    private dataSharing:DataSharingService,
    private notes: NotesService,
    private snackBar: MatSnackBar) { }

  ngOnInit() {
    this.getTrash();
    this.dataSharing.currentCard.subscribe(change => this.change=change) 
  }

  getTrash(){
    this.notes.getTrash(this.userData.email).subscribe((status:any)=>{
      if(status != null){
        this.message = status;
      }
      else{
        this.snackBar.open('No trash to show.','', {duration: 2000});
      }
    });
  }

  delete(id){
    this.notes.delete(id).subscribe((status:any)=>{
      if(status != null){
        this.getTrash();
        this.snackBar.open('Deleted.','', {duration: 2000});
      }
    });
  }

  restore(id){
    this.notes.restore(id).subscribe((status:any)=>{
      if(status != null){
        this.getTrash();
        this.snackBar.open('Restored.','', {duration: 2000});
      }
    });
  }

  deleteAll(){
    this.notes.deleteAll(this.userData.email).subscribe((status:any)=>{
      if(status != null){
        this.getTrash();
        this.snackBar.open('Deleted.','', {duration: 2000});
      }
    });
  }

  restoreAll(){
    this.notes.restoreAll(this.userData.email).subscribe((status:any)=>{
      if(status != null){
        this.getTrash();
        this.snackBar.open('Restored.','', {duration: 2000});
      }
    });
  }
}
