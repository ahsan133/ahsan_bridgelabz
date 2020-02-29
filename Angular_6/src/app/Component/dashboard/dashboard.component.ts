import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import {CollaboratorComponent} from 'src/app/Component/collaborator/collaborator.component';

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

  constructor(private router:Router, public account: AccountService, public snackbar: MatSnackBar,
    public dialog: MatDialog) { }

  ngOnInit() {
  }

  logout(){
    this.account.logout(this.userData.email).subscribe((status:any)=>{
      if (status == "success"){
        this.router.navigate(['/login']);
        this.snackbar.open('logged out')
      }
    });
  }

  AddCollaborator(): void{
    const dialogRef =this.dialog.open(CollaboratorComponent ,{ width: '370px'});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    })
  }
 
   ChangeProfile(): void {
 const dialogRef =this.dialog.open(ProfilePicture,{ width: '370px',
 height: '230px' , data:{ image: this.image }});

 dialogRef.afterClosed().subscribe(result => {
   console.log('The dialog was closed');
   this.image =result;
 });
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
  files: any;

  constructor(public account: AccountService,
    public dialogRef: MatDialogRef<ProfilePicture>){ }


   onNoClick(): void {
     this.dialogRef.close();
   }
   onSelectFile(files: FileList) {

    if (files.length === 0)
      return;
  
    this.fileToUpload = files.item(0);
    this.account.uploadProfilePicture(this.userData.email ,this.fileToUpload).subscribe((status :any) => {
        if(status != null)
        {
          this.dialogRef.close();
        }
        this.userData.image = status.result;
    });
  }

}

