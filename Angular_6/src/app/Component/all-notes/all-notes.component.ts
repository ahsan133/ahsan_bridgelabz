import { Component, OnInit, ViewChild  } from '@angular/core';
import {GetNotesComponent} from 'src/app/Component/get-notes/get-notes.component';
import { MatDialog } from '@angular/material';
import { CardComponent } from '../card/card.component';

@Component({
  selector: 'app-all-notes',
  templateUrl: './all-notes.component.html',
  styleUrls: ['./all-notes.component.scss']
})
export class AllNotesComponent implements OnInit {
  message:any;

  constructor(public dialog:MatDialog ) { }

  ngOnInit() {
  }

  receiveMessage($event) {
     this.message = $event
     console.log(this.message);
     
   }

   cardOpen(): void{
    const dialogRef =this.dialog.open(CardComponent,{ width: '500px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}
