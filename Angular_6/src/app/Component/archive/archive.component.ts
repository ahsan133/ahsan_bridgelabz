import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { CardComponent } from '../card/card.component';
import { DataSharingService } from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {
  userData =JSON.parse(localStorage.getItem('userData'));
  message  = [];
  change :boolean;
  constructor(
    private dataSharing: DataSharingService,
    private notes:NotesService,
    private snackBar:MatSnackBar,
    public dialog:MatDialog) { }

  ngOnInit() {
    this.getArchive();

    this.dataSharing.currentMessage.subscribe((change) =>{
      if(change == true){
        this.getArchive();
        this.dataSharing.changeMessage(false);
      }
      }); 
      this.dataSharing.currentCard.subscribe(change => this.change=change)  
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

  removeRemainder(id){
    this.notes.removeRemainder(id).subscribe((status : any)=>{
      if(status != null){
        this.getArchive();
        this.snackBar.open('Remainder removed','', {duration: 2000});
      }
    });
  }
}
