import { Component, OnInit, Input  } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-get-note-collaborator',
  templateUrl: './get-note-collaborator.component.html',
  styleUrls: ['./get-note-collaborator.component.scss']
})
export class GetNoteCollaboratorComponent implements OnInit {
  @Input() data;

  message  = [];

  constructor(
    private notes: NotesService,
    public snackBar:MatSnackBar) { }

  ngOnInit() {
    this.getCollaborators();
  }

  getCollaborators(){
    this.notes.getCollaborators(this.data.id).subscribe((status : any)=>{
      this.message = status;    
    });
  }

  removeCollaborator(one: any): void{
    console.log(one);
    
    this.notes.removeCollaborator(one ).subscribe((status:any)=>{
      if(status != null){
        this.snackBar.open('Collaborator removed.','', {duration: 2000});
      }
    });
  }
}
