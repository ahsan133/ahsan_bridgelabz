import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';
import { ImageCroppedEvent, base64ToFile } from 'ngx-image-cropper';
import { LabelsComponent } from '../labels/labels.component';

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
  image: any;
  fileToUpload: File;
  
  constructor(
    private router:Router, 
    public account: AccountService, 
    public snackbar: MatSnackBar,
    public dialog: MatDialog) { }

  ngOnInit() {
   this.displayNotes();
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
