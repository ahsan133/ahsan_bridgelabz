import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/account.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';


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

  ChangeProfile(): void {
const dialogRef =this.dialog.open(ProfilePicture,{ width: '550px',
height: '300px' });

dialogRef.afterClosed().subscribe(result => {
  console.log('The dialog was closed');
});
  }
} 


@Component({
  selector: 'ProfilePicdialog',
  templateUrl: './ProfilePicdialog.component.html',
})
export class ProfilePicture {
  url: string | ArrayBuffer;

  constructor(
    public dialogRef: MatDialogRef<ProfilePicture>){ }
 
   onNoClick(): void {
     this.dialogRef.close();
   }

   onSelectFile(event) { // called each time file input changes
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();

      reader.readAsDataURL(event.target.files[0]); // read file as data url

      reader.onload = (event) => { // called once readAsDataURL is completed
        this.url = event.target.result;
      }
    }
}
}