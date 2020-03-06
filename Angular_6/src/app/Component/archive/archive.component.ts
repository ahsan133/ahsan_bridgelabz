import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {
  userData =JSON.parse(localStorage.getItem('userData'));
  message  = [];

  constructor(
    private notes:NotesService,
    private snackBar:MatSnackBar) { }

  ngOnInit() {
    this.getArchive();
  }

  getArchive(){
    this.notes.getArchive(this.userData.email).subscribe((status: any)=>{
      if(status != null){
        this.message = status;
      }
      else{
        this.snackBar.open('No archive to show.','', {duration: 2000});
      }
    });
  }
}
