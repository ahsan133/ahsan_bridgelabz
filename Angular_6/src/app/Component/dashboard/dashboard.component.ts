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
  image: any;


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
  url: string | ArrayBuffer;
  event;

  constructor(public account: AccountService,
    public dialogRef: MatDialogRef<ProfilePicture>){ }


   onNoClick(): void {
     this.dialogRef.close();
   }

   onSelectFile() {

    if (this.event) {
      var reader = new FileReader();

      // reader.readAsDataURL(this.event); 

      // reader.onload = (this.event) => { 
      //   this.url = this.event.target.result;
      // }
      this.account.ProfilePic(this.userData.email, this.event).subscribe((status:any)=>{
       if(status == "success"){
        this.onNoClick();
       }
      });

      }
    }
}
