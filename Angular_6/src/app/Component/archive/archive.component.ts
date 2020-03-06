import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { CardComponent } from '../card/card.component';

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
    private snackBar:MatSnackBar,
    public dialog:MatDialog) { }

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

  matcardOpen(onenote :any): void{
    const dialogRef =this.dialog.open(CardComponent,{ width: '500px', data:onenote});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}
