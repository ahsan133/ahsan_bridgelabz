import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatDialog } from '@angular/material';
import { CardComponent } from '../card/card.component';

@Component({
  selector: 'app-get-notes',
  templateUrl: './get-notes.component.html',
  styleUrls: ['./get-notes.component.scss']
})
export class GetNotesComponent implements OnInit {
  userData =JSON.parse(localStorage.getItem('userData'));
  message  = [];

  @Output() messageEvent = new EventEmitter<string>()

  constructor(private note:NotesService, public dialog:MatDialog ) { }

  ngOnInit() {
    this.getNotes();
  }

  getNotes(){
   this.note.getNotes(this.userData.email).subscribe((status : any)=>{
     this.messageEvent.emit(status);
     this.message = status;
   });
  }

  matcardOpen(onenote :any): void{
    const dialogRef =this.dialog.open(CardComponent,{ width: '500px', data:onenote});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}
