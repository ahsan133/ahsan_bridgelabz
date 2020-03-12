import { Component, OnInit, Input } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';
import {DataSharingService} from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-pin',
  templateUrl: './pin.component.html',
  styleUrls: ['./pin.component.scss']
})
export class PinComponent implements OnInit {
  @Input() data;

  constructor(
    private dataSharing:DataSharingService,
    private snackBar:MatSnackBar,
    private note:NotesService
  ) { }

  ngOnInit() {
  }

  pinNote(){
    this.note.pinNote(this.data.id).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeMessage(true);
        this.snackBar.open('Note pinned.','', {duration: 2000});
      }
    });
  }
  unpinNote(){
    this.note.unpinNote(this.data.id).subscribe((status)=>{
      if(status != null){
        this.dataSharing.changeMessage(true);
        this.snackBar.open('Note Unpinned.','', {duration: 2000});
      }
    });
  }
}
