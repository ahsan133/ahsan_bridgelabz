import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-get-notes',
  templateUrl: './get-notes.component.html',
  styleUrls: ['./get-notes.component.scss']
})
export class GetNotesComponent implements OnInit {
  userData =JSON.parse(localStorage.getItem('userData'));
  message  = [];

  @Output() messageEvent = new EventEmitter<string>()

  constructor(private note:NotesService) { }

  ngOnInit() {
    this.getNotes();
  }

  getNotes(){
   this.note.getNotes(this.userData.email).subscribe((status : any)=>{
     this.messageEvent.emit(status);
     this.message = status;
   });
  }
}
