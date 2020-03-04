import { Component, OnInit } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import {CardComponent} from 'src/app/Component/card/card.component';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {
  noteData =JSON.parse(localStorage.getItem('noteData'));

  title;
  description;
  card1 = true;
  card2 = false;
  constructor() { }

  ngOnInit() {
  }

  note(){
    this.card2=true;
    this.card1=false;
  }
  
  close(){
    this.card1 = true;
    this.card2 = false;
  }
}
