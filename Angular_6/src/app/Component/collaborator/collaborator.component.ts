import { Component, OnInit } from '@angular/core';
import {MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-collaborator',
  templateUrl: './collaborator.component.html',
  styleUrls: ['./collaborator.component.scss']
})
export class CollaboratorComponent implements OnInit {
  userData=JSON.parse(localStorage.getItem('userData'));
  profilePic = this.userData.profilePicture;
  first = this.userData.firstName;
  last = this.userData.lastName;
  email = this.userData.email;

  constructor(public dialogRef: MatDialogRef<CollaboratorComponent>) { }

  ngOnInit() {
  }

  onNoClick(): void {
    this.dialogRef.close();
}
}