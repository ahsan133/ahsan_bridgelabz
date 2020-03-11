import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatDialog, MatSnackBar } from '@angular/material';
import { CardComponent } from '../card/card.component';
import {DataSharingService} from 'src/app/Services/data-sharing.service';
import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';

@Component({
  selector: 'app-get-notes',
  templateUrl: './get-notes.component.html',
  styleUrls: ['./get-notes.component.scss']
})
export class GetNotesComponent implements OnInit {
  userData =JSON.parse(localStorage.getItem('userData'));
  message  = [];

  change :boolean;

  constructor(
    private dataSharing:DataSharingService,
    private snackBar:MatSnackBar,
    private note:NotesService,
    public dialog:MatDialog ) { }

  ngOnInit() {
    this.getNotes();

    this.dataSharing.currentMessage.subscribe((change) =>{
      if(change == true){
        this.getNotes();
        this.dataSharing.changeMessage(false);
      }
      }); 
      
    this.dataSharing.currentCard.subscribe(change => this.change=change)  
  }

  drop(event: CdkDragDrop<number[]>) {
    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {
      transferArrayItem(event.previousContainer.data,
                        event.container.data,
                        event.previousIndex,
                        event.currentIndex);
    }
  }
  // drop1(event: CdkDragDrop<string[]>) {
  //   moveItemInArray(this.message, event.previousIndex, event.currentIndex);
  // }
  getNotes(){
   this.note.getNotes(this.userData.email).subscribe((status : any)=>{
     this.message = status;
   });
  }

  matcardOpen(onenote :any): void{
    const dialogRef =this.dialog.open(CardComponent,{ width: '500px', data:onenote});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  removeRemainder(id){
    this.note.removeRemainder(id).subscribe((status : any)=>{
      if(status != null){
        this.getNotes();
        this.snackBar.open('Remainder removed','', {duration: 2000});
      }
    });
  }
 
}
