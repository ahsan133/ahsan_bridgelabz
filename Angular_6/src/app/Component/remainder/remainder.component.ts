import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Services/notes.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { CardComponent } from '../card/card.component';
import { DataSharingService } from 'src/app/Services/data-sharing.service';

@Component({
  selector: 'app-remainder',
  templateUrl: './remainder.component.html',
  styleUrls: ['./remainder.component.scss']
})

export class RemainderComponent implements OnInit {
  userData = JSON.parse(localStorage.getItem('userData'));
  message = [];

  constructor(
    private dataSharing:DataSharingService,
    private notes: NotesService,
    private snackBar: MatSnackBar,
    public dialog:MatDialog) { }

  ngOnInit() {
    this.getRemainder();

    this.dataSharing.currentMessage.subscribe((change) =>{
      if(change == true){
        this.getRemainder();
        this.dataSharing.changeMessage(false);
      }
      }); 

  }

  getRemainder(){
    this.notes.getRemainder(this.userData.email).subscribe((status : any)=>{
      if(status != null){
        this.message = status;
      }
      else{
        this.snackBar.open('No remainder to show.','', {duration: 2000});
      }
    });
  }

  removeRemainder(id){
    this.notes.removeRemainder(id).subscribe((status : any)=>{
      if(status != null){
        this.getRemainder();
        this.snackBar.open('Remainder removed','', {duration: 2000});
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
