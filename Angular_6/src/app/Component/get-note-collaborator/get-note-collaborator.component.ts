import { Component, OnInit, Input  } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-get-note-collaborator',
  templateUrl: './get-note-collaborator.component.html',
  styleUrls: ['./get-note-collaborator.component.scss']
})
export class GetNoteCollaboratorComponent implements OnInit {
  @Input() data;

  message  = [];

  constructor(
    private notes: NotesService) { }

  ngOnInit() {
    this.getCollaborators();
  }

  getCollaborators(){
    this.notes.getCollaborators(this.data.id).subscribe((status : any)=>{
      this.message = status;
      console.log(status);
      
    });
  }

}
