import { Component, OnInit, } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import { ImageCroppedEvent, base64ToFile } from 'ngx-image-cropper';
import { DataSharingService} from 'src/app/Services/data-sharing.service';
import { NotesService } from 'src/app/Services/notes.service';
import { EditLabelComponent } from '../edit-label/edit-label.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  
  userData=JSON.parse(localStorage.getItem('userData'));
  profilePic = this.userData.profilePicture;
  first = this.userData.firstName;
  last = this.userData.lastName;
  email = this.userData.email;
  id = this.userData.id;
  image: any;
  fileToUpload: File;
  label=[];
  card1;


  constructor(
    private dataSharing:DataSharingService,
    private note:NotesService,
    private dataShare: DataSharingService,
    private router:Router, 
    public account: AccountService, 
    public snackbar: MatSnackBar,
    public dialog: MatDialog) { }

  ngOnInit() {
   this.displayNotes();
   this.getLabel();

   this.dataSharing.currentLabel.subscribe((change) =>{
    if(change == true){
      this.getLabel();
      this.dataSharing.changeLabel(false);
    }
    }); 

  }

  getLabel(){
    this.note.getLabel(this.userData.email).subscribe((status:any)=>{
      if(status != null){
        this.label = status;
      }
    });
   }

   editLabel(): void{
    const dialogRef =this.dialog.open(EditLabelComponent ,{ width: '300px', data: this.label});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
   }

  viewGrid(){
    this.card1=!this.card1;
    this.dataShare.changeCard(true);
  }

  viewList(){
    this.card1=!this.card1;
    this.dataShare.changeCard(false);
  }

  logout(){
    this.account.logout(this.userData.email).subscribe((status:any)=>{
      if (status == "success"){
        localStorage.removeItem('userData');
        this.router.navigate(['/login']);
        this.snackbar.open('logged out','', {duration: 2000});
      }
    });
  }

  AddCollaborator(): void{
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
 
   ChangeProfile(): void {
 const dialogRef =this.dialog.open(ProfilePicture,{ width: '460px',
 height: '440px' , data:{ image: this.image }});

  dialogRef.afterClosed().subscribe(result => {
   console.log('The dialog was closed');
   this.image =result;
  });
   }

   displayNotes(){
     this.router.navigate(['/dashboard/allNotes']);
   } 

   displayRemainders(){
     this.router.navigate(['/dashboard/remainder']); 
   }

   displayArchive(){
     this.router.navigate(['/dashboard/archive']);
   }

   displayTrash(){
     this.router.navigate(['/dashboard/trash']);
   }
} 

@Component({
  selector: 'ProfilePicdialog',
  templateUrl: './ProfilePicdialog.component.html',
  styleUrls: ['./ProfilePicdialog.component.scss']
})
export class ProfilePicture{
  userData=JSON.parse(localStorage.getItem('userData'));
  image: any;
  fileToUpload: File;
  filename;
  imageChangedEvent: any = '';
  croppedImage: any = '';

  constructor(public account: AccountService,
    public snackbar: MatSnackBar,
    public dialogRef: MatDialogRef<ProfilePicture>){ }


   onNoClick(): void {
     this.dialogRef.close();
   }
   
  fileChangeEvent(event: any): void {
    this.filename = event.target.files[0].name;
    console.log(this.filename + " name");
    
    this.imageChangedEvent = event;
  }
  imageCropped(event: ImageCroppedEvent) {
    this.croppedImage = base64ToFile(event.base64);
    this.fileToUpload = new File([this.croppedImage], this.filename);
  }

onSelectFile() {
  this.account.uploadProfilePicture(this.userData.email ,this.fileToUpload).subscribe((status :any) => {
      if(status != null)
      {
        this.dialogRef.close();
      }
      this.userData.image = status.result;
      this.snackbar.open('Profile picture updated.','', {duration: 2000});
  });
}

}
