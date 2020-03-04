import { Component, OnInit, ViewChild  } from '@angular/core';
import {GetNotesComponent} from 'src/app/Component/get-notes/get-notes.component';

@Component({
  selector: 'app-all-notes',
  templateUrl: './all-notes.component.html',
  styleUrls: ['./all-notes.component.scss']
})
export class AllNotesComponent implements OnInit {
  message:any;

  constructor( ) { }

  ngOnInit() {
  }

  receiveMessage($event) {
     this.message = $event
     console.log(this.message);
     
   }
}
